using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.Models
{
    /// AlertDataModel - Jacob Monger
    /// <summary>
    /// Used in the alert view model as individual list items in the alert list
    /// </summary>

    public class AlertDataModel
    {
        public String Time { get; set; }

        public String Alert { get; set; }
        public double AlertValue { get; set; }
        public String Sign { get; set; }
        public double Threshold { get; set; }
        public String ThresholdInfo { get; set; } 

        /// AlertDataModel(constructor) - Jacob Monger
        /// <summary>
        /// Used to set up a list item. Basic logic to identify in which direction and time the alert was excided.
        /// </summary>
        /// <param name="alert"> String used to identify the alert.</param>
        /// <param name="alertValue">double which carries the alert value.</param>
        /// <param name="threshold">double which carries the alert thrshold.</param>

        public AlertDataModel(String alert, double alertValue, double threshold)
        {
            Time = DateTime.Now.ToString("HH:mm:ss");
            Alert = alert;
            AlertValue = alertValue;
            Threshold = threshold;
            if (Alert.Contains("Max") == true)
            {
                Sign = " > ";
                ThresholdInfo = " (threshold)";
            }
            else if (Alert.Contains("Min") == true)
            {
                Sign = " < ";
                ThresholdInfo = " (threshold)";
            }
            else
            {
                Sign = "  ";
                ThresholdInfo = null;
            }

        }
    }
}
