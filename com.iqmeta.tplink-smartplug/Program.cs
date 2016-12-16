using Newtonsoft.Json;
using System;

namespace com.iqmeta.tplink_smartplug
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                dynamic plugResponse = Utils.SendToSmartPlug("192.168.178.159", Commands.SysInfoAndEmeter());

                Console.Write(JsonConvert.SerializeObject(plugResponse, Formatting.Indented));
                Console.ReadKey();

                Utils.SendToSmartPlug("192.168.178.159", Commands.TurnOn());
                Console.ReadKey();

                Utils.SendToSmartPlug("192.168.178.159", Commands.TurnOff());

                dynamic stats = Utils.SendToSmartPlug("192.168.178.159", Commands.MonthStats(2016));
                Console.Write(JsonConvert.SerializeObject(stats, Formatting.Indented));

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houston, we have a " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
