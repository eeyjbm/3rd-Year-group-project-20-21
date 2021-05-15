using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.Models
{
    /// AlertListItemModel - Jacob Monger
    /// <summary>
    /// A list item in the settings view model.
    /// </summary>

    public class AlertListItemModel
    {
        public String AlertName { get; set; }
        public String Exceeded { get; set; }
        public String ThresholdToDisplay { get; set; }
        public double Threshold { get; set; }

        public double AlertValue { get; set; }

        /// AlertListItemModel(contructor) - Jacob Monger
        /// <summary>
        /// Used to set up a list item in the settings view model, threshold excided case.
        /// </summary>
        /// <param name="alertName"> String used to identify the alert.</param>
        /// <param name="exceeded"> string set when excided is true</param>
        /// <param name="threshold"> double containg the threshold value used see if its the biggest/smallest error</param>
        /// <param name="ThresholdToDisplay"> string  showing the treshold as a string</param>
        public AlertListItemModel(string alertName, string exceeded, string thresholdToDisplay, double threshold)
        {
            AlertName = alertName;
            AlertValue = (double)Properties.Settings.Default[AlertName];
            Exceeded = exceeded;
            ThresholdToDisplay = thresholdToDisplay;
            Threshold = threshold;
        }

        /// AlertListItemModel(contructor) - Jacob Monger
        /// <summary>
        /// Used to set up a list item in the settings view model.
        /// </summary>
        /// <param name="alertName"> String used to identify the alert.</param>
        public AlertListItemModel(string alertName)
        {
            AlertName = alertName;
            AlertValue = (double)Properties.Settings.Default[AlertName];
            Exceeded = null;
            ThresholdToDisplay = null;
            Threshold = 0;
        }
    }
}
