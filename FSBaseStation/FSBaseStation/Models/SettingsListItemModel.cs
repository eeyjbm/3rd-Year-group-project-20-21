using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.Models
{    /// SettingsListItemModel - Jacob Monger
     /// <summary>
     /// A list item in the settings view model.
     /// </summary>
    public class SettingsListItemModel
    {
        public String SettingsName { get; set; }
        public double SettingsValue { get; set; }

        /// AlertDataModel(constructor) - Jacob Monger
        /// <summary>
        /// Used to set up a list item in settings view model.
        /// </summary>
        /// <param name="settingsName"> Name of setting.</param>

        public SettingsListItemModel(string settingsName)
        {
            SettingsName = settingsName;
            SettingsValue = (double)Properties.Settings.Default[SettingsName];
        }
    }
}
