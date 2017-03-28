using Newtonsoft.Json;
using System;

namespace com.iqmeta.tplink_smartplug
{
    class Program
    {
        static void Main(string[] args)
        {
            string bulbIP = "192.168.1.2";
            string plugOrSwitchIP = "192.168.1.3";
            try
            {
                var state = new BulbState();
                state.transition_light_state.on_off = 1;
                state.transition_light_state.brightness = 50;
                dynamic bulbResponse = Utils.SendToSmartBulb(bulbIP, state);
                
                Console.Write(JsonConvert.SerializeObject(bulbResponse, Formatting.Indented));
                Console.ReadKey();

                dynamic plugResponse = Utils.SendToSmartPlugOrSwitch(plugOrSwitchIP, Commands.SysInfoAndEmeter());
                Console.WriteLine(JsonConvert.SerializeObject(plugResponse, Formatting.Indented));
                Console.ReadKey();

                Utils.SendToSmartPlugOrSwitch(plugOrSwitchIP, Commands.TurnOn());
                Console.ReadKey();

                Utils.SendToSmartPlugOrSwitch(plugOrSwitchIP, Commands.TurnOff());

                dynamic stats = Utils.SendToSmartPlugOrSwitch(plugOrSwitchIP, Commands.MonthStats(2016));
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
