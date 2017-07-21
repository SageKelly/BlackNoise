using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BlackNoise
{
    public class TimerData
    {
        /// <summary>
        /// The ID of the notification
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the Notification
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The interval (stored in milliseconds) of the 
        /// </summary>
        public int TimerInterval { get; set; }

        /// <summary>
        /// The sound the alarm will make when it triggers
        /// </summary>
        public MediaElement Chime { get; set; }
    }
}
