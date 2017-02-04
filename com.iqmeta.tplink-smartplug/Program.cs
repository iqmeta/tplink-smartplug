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
                var state = new BulbState();
                state.transition_light_state.on_off = 0;
                dynamic bulbResponse = Utils.SendToSmartBulb("192.168.2.8", state);
                
                Console.Write(JsonConvert.SerializeObject(bulbResponse, Formatting.Indented));
                Console.ReadKey();

                dynamic plugResponse = Utils.SendToSmartPlugOrSwitch("192.168.2.2", Commands.SysInfoAndEmeter());
                Console.WriteLine(JsonConvert.SerializeObject(plugResponse, Formatting.Indented));
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
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
