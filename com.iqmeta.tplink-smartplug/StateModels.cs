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
        /// <summary>
        /// 1 = On; 0 = Off
        /// </summary>
        public byte on_off { get; set; } = 1;
        /// <summary>
        /// Transition time from one state to the next in milliseconds
        /// </summary>
        public int transition_period { get; set; } = 2000;
        public int hue { get; set; } = 0;
        public int saturation { get; set; } = 0;
        public int color_temp { get; set; } = 0;
        /// <summary>
        /// Dim the light from 100 to 0 (for LB100, only increments of 10 will work)
        /// </summary>
        public int brightness { get; set; } = 100;
    }
}
