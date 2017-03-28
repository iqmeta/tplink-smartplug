using Newtonsoft.Json;

namespace com.iqmeta.tplink_smartplug
{   
    public static class Commands
    {
        public static string TurnOff()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    set_relay_state = new
                    {
                        state = 0
                    }
                }
            });
        }
        public static string TurnOn()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    set_relay_state = new
                    {
                        state = 1
                    }
                }
            });
        }
        public static string SysInfo()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    get_sysinfo = new
                    {
                    }
                }
            });
        }
        public static string SysInfoAndEmeter()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    get_sysinfo = new
                    {
                    }
                },
                emeter = new
                {
                    get_realtime = new { },
                    get_vgain_igain = new { }
                }
            });
        }
        public static string Emeter()
        {
            return JsonConvert.SerializeObject(new
            {
                emeter = new
                {
                    get_realtime = new { },
                    get_vgain_igain = new { }
                }
            });
        }
        public static string MonthStats(int year)
        {
            return JsonConvert.SerializeObject(new
            {
                emeter = new
                {
                    get_monthstat = new { year = year},
                }
            });
        }
    }
}
