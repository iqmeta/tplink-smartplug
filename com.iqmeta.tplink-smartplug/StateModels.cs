using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.iqmeta.tplink_smartplug
{
    public class BulbState
    {
        public TransitionLightState transition_light_state { get; set; } = new TransitionLightState();
    }

    public class TransitionLightState
    {
        public byte on_off { get; set; } = 1;
        public int transition_period { get; set; } = 0;
        public int hue { get; set; } = 0;
        public int saturation { get; set; } = 0;
        public int color_temp { get; set; } = 0;
        public int brightness { get; set; } = 100;
    }
}
