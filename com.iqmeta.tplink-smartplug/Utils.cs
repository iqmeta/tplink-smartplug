using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace com.iqmeta.tplink_smartplug
{
    public static class Utils
    {
        public static dynamic SendToSmartPlug(string ip, string jsonPayload, int port = 9999)
        {
            using (var sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                var tpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                sender.Connect(tpEndPoint);
                sender.Send(Utils.Encrypt(jsonPayload));
                byte[] buffer = new byte[2048];
                int bytesLen = sender.Receive(buffer);
                if (bytesLen > 0)
                {
                    return JsonConvert.DeserializeObject<dynamic>(Utils.Decrypt(Encoding.UTF7.GetString(buffer, 4, bytesLen - 4)));                    
                }
                else
                {
                    throw new Exception("No answer.. something went wrong");
                }
            }
        }
        private static UInt32 ReverseBytes(UInt32 value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                   (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }
        public static byte[] Encrypt(string payload)
        {
            byte key = 0xAB;
            byte[] cipherBytes = new byte[payload.Length];
            byte[] header = BitConverter.GetBytes(ReverseBytes((UInt32)payload.Length));
            for (var i = 0; i < payload.Length; i++)
            {
                cipherBytes[i] = Convert.ToByte(payload[i] ^ key);
                key = cipherBytes[i];
            }
            return header.Concat(cipherBytes).ToArray();
        }
        public static string Decrypt(string ciphertext)
        {
            byte key = 0xAB;
            byte nextKey;
            string result = "";
            for (int i = 0; i < ciphertext.Length; i++)
            {
                nextKey = Convert.ToByte(ciphertext[i]);
                result += (char)(Convert.ToByte(ciphertext[i]) ^ key);
                key = nextKey;
            }
            return result;
        }
    }
}
