using FSBaseStation.Commands;
using FSBaseStation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSBaseStation.ViewModels
{
    /// SettingsViewModel- Jacob Monger
    /// <summary>
    /// view model for settings view - used adjust various settings and alert limits
    /// </summary>
    public class SettingsViewModel : ObservableObject
    {
        public AlertViewModel AlertViewModelInstance { get; set; }
        public RelayCommand UpdateSettingsCommand { get; private set; }
        public RelayCommand UpdateAlertCommand { get; private set; }

        public ObservableCollection<SettingsListItemModel> SettingsList { get; } = new ObservableCollection<SettingsListItemModel>();
        public ObservableCollection<AlertListItemModel> AlertList { get; } = new ObservableCollection<AlertListItemModel>();

        private String _selectIndexValue;
        public String SelectIndexValue
        {
            get
            {
                return _selectIndexValue;
            }
            set
            {
                _selectIndexValue = value;
                OnPropertyChanged("SelectIndexValue");
            }
        }

        private string _newSettings;
        public string NewSettings
        {
            get
            {
                return _newSettings;
            }
            set
            {
                _newSettings = value;
                OnPropertyChanged("NewSettings");
            }
        }

        private String _selectAlertValue;
        public String SelectAlertValue
        {
            get
            {
                return _selectAlertValue;
            }
            set
            {
                _selectAlertValue = value;
                OnPropertyChanged("SelectAlertValue");
            }
        }

        private string _newAlert;
        public string NewAlert
        {
            get
            {
                return _newAlert;
            }
            set
            {
                 _newAlert = value;
                 OnPropertyChanged("NewAlert");
            }
        }
        /// SettingsViewModel (Constructor)- Jacob Monger
        /// <summary>
        /// Sets up commands, add settings and alert limits to respective lists
        /// </summary>
        public SettingsViewModel()
        {
            UpdateSettingsCommand = new RelayCommand(UpdateSettings);
            UpdateAlertCommand = new RelayCommand(UpdateAlert);
             
            App.Current.Dispatcher.Invoke((Action)delegate //delegate to UI thread
            {
                SettingsList.Add(new SettingsListItemModel("ECULeftTorqueDemandXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("ECULeftTorqueDemandXLagMax"));
                SettingsList.Add(new SettingsListItemModel("ECULeftTorqueDemandXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("ECURightTorqueDemandXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("ECURightTorqueDemandXLagMax"));
                SettingsList.Add(new SettingsListItemModel("ECURightTorqueDemandXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("ECUAcclerationDemandXLagSpacing")); 
                SettingsList.Add(new SettingsListItemModel("ECUAcclerationDemandXLagMax"));
                SettingsList.Add(new SettingsListItemModel("ECUAcclerationDemandXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("ECUFrontBrakeDemandXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("ECUFrontBrakeDemandXLagMax"));
                SettingsList.Add(new SettingsListItemModel("ECUFrontBrakeDemandXNofDataPoint"));  

                SettingsList.Add(new SettingsListItemModel("KistlerVelXXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("KistlerVelXXLagMax"));
                SettingsList.Add(new SettingsListItemModel("KistlerVelXXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("KistlerVelYXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("KistlerVelYXLagMax"));
                SettingsList.Add(new SettingsListItemModel("KistlerVelYXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationXXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationXXLagMax"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationXXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationYXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationYXLagMax"));
                SettingsList.Add(new SettingsListItemModel("KistlerAcclerationYXNofDataPoint"));

                SettingsList.Add(new SettingsListItemModel("RightInverterSpeedXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("RightInverterSpeedXLagMax"));
                SettingsList.Add(new SettingsListItemModel("RightInverterSpeedXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("RightInverterMechanicalPowerXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("RightInverterMechanicalPowerXLagMax"));
                SettingsList.Add(new SettingsListItemModel("RightInverterMechanicalPowerXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("RightInverterAbsolutePhaseCurrentXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("RightInverterAbsolutePhaseCurrentXLagMax"));
                SettingsList.Add(new SettingsListItemModel("RightInverterAbsolutePhaseCurrentXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("RightInverterLinkVoltageDCXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("RightInverterLinkVoltageDCXLagMax"));
                SettingsList.Add(new SettingsListItemModel("RightInverterLinkVoltageDCXNofDataPoint"));

                SettingsList.Add(new SettingsListItemModel("LeftInverterSpeedXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterSpeedXLagMax"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterSpeedXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterMechanicalPowerXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterMechanicalPowerXLagMax"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterMechanicalPowerXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterAbsolutePhaseCurrentXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterAbsolutePhaseCurrentXLagMax"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterAbsolutePhaseCurrentXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterLinkVoltageDCXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterLinkVoltageDCXLagMax"));
                SettingsList.Add(new SettingsListItemModel("LeftInverterLinkVoltageDCXNofDataPoint"));

                SettingsList.Add(new SettingsListItemModel("RightPCBTempXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("RightPCBTempXLagMax"));
                SettingsList.Add(new SettingsListItemModel("RightPCBTempXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("LeftPCBTempXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("LeftPCBTempXLagMax"));
                SettingsList.Add(new SettingsListItemModel("LeftPCBTempXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("TotalAverageBatteryTempXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("TotalAverageBatteryTempXLagMax"));
                SettingsList.Add(new SettingsListItemModel("TotalAverageBatteryTempXNofDataPoint"));
                SettingsList.Add(new SettingsListItemModel("GearBoxTempXLagSpacing"));
                SettingsList.Add(new SettingsListItemModel("GearBoxTempXLagMax"));
                SettingsList.Add(new SettingsListItemModel("GearBoxTempXNofDataPoint"));

                SettingsList.Add(new SettingsListItemModel("GaugeLeftInverterSpeedMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeLeftInverterSpeedMax"));
                SettingsList.Add(new SettingsListItemModel("GaugeRightInverterSpeedMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeRightInverterSpeedMax"));
                SettingsList.Add(new SettingsListItemModel("GaugeLeftMechanicalPowerMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeLeftMechanicalPowerMax"));
                SettingsList.Add(new SettingsListItemModel("GaugeRightMechanicalPowerMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeRightMechanicalPowerMax"));
                SettingsList.Add(new SettingsListItemModel("GaugeVelocityXMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeVelocityXMax"));
                SettingsList.Add(new SettingsListItemModel("GaugeVelocityYMin"));
                SettingsList.Add(new SettingsListItemModel("GaugeVelocityYMax"));

                SettingsList.Add(new SettingsListItemModel("LenghtOfAlertList")); // number of items in alert list
                SettingsList.Add(new SettingsListItemModel("WriteToDataLog"));  // enable data logging

            }); 

            App.Current.Dispatcher.Invoke((Action)delegate
            {
                AlertList.Add(new AlertListItemModel("ECULeftTorqueDemandMax"));
                AlertList.Add(new AlertListItemModel("ECULeftTorqueDemandMin"));
                AlertList.Add(new AlertListItemModel("ECURightTorqueDemandMax"));  
                AlertList.Add(new AlertListItemModel("ECURightTorqueDemandMin")); 
                AlertList.Add(new AlertListItemModel("ECUAcclerationDemandMax"));
                AlertList.Add(new AlertListItemModel("ECUAcclerationDemandMin"));
                AlertList.Add(new AlertListItemModel("ECUFrontBrakeDemandMax"));
                AlertList.Add(new AlertListItemModel("ECUFrontBrakeDemandMin"));

                AlertList.Add(new AlertListItemModel("KistlerVelXMax"));
                AlertList.Add(new AlertListItemModel("KistlerVelXMin"));
                AlertList.Add(new AlertListItemModel("KistlerVelYMax"));
                AlertList.Add(new AlertListItemModel("KistlerVelYMin")); 
                AlertList.Add(new AlertListItemModel("KistlerAcclerationXMax"));
                AlertList.Add(new AlertListItemModel("KistlerAcclerationXMin"));
                AlertList.Add(new AlertListItemModel("KistlerAcclerationYMax"));
                AlertList.Add(new AlertListItemModel("KistlerAcclerationYMin"));

                AlertList.Add(new AlertListItemModel("RightInverterSpeedMax"));
                AlertList.Add(new AlertListItemModel("RightInverterSpeedMin"));
                AlertList.Add(new AlertListItemModel("RightInverterMechanicalPowerMax"));
                AlertList.Add(new AlertListItemModel("RightInverterMechanicalPowerMin"));
                AlertList.Add(new AlertListItemModel("RightInverterAbsolutePhaseCurrentMax"));
                AlertList.Add(new AlertListItemModel("RightInverterAbsolutePhaseCurrentMin"));
                AlertList.Add(new AlertListItemModel("RightInverterLinkVoltageDCMax"));
                AlertList.Add(new AlertListItemModel("RightInverterLinkVoltageDCMin"));

                AlertList.Add(new AlertListItemModel("LeftInverterSpeedMax"));
                AlertList.Add(new AlertListItemModel("LeftInverterSpeedMin"));
                AlertList.Add(new AlertListItemModel("LeftInverterMechanicalPowerMax"));
                AlertList.Add(new AlertListItemModel("LeftInverterMechanicalPowerMin"));
                AlertList.Add(new AlertListItemModel("LeftInverterAbsolutePhaseCurrentMax"));
                AlertList.Add(new AlertListItemModel("LeftInverterAbsolutePhaseCurrentMin"));
                AlertList.Add(new AlertListItemModel("LeftInverterLinkVoltageDCMax"));
                AlertList.Add(new AlertListItemModel("LeftInverterLinkVoltageDCMin"));

                AlertList.Add(new AlertListItemModel("RightPCBTempMax"));
                AlertList.Add(new AlertListItemModel("RightPCBTempMin"));
                AlertList.Add(new AlertListItemModel("LeftPCBTempMax"));
                AlertList.Add(new AlertListItemModel("LeftPCBTempMin"));
                AlertList.Add(new AlertListItemModel("TotalAverageBatteryTempMax"));
                AlertList.Add(new AlertListItemModel("TotalAverageBatteryTempMin"));
                AlertList.Add(new AlertListItemModel("GearBoxTempMax"));
                AlertList.Add(new AlertListItemModel("GearBoxTempMin"));
            });

            SelectAlertValue = "ECULeftTorqueDemandMax";
            SelectIndexValue = "ECULeftTorqueDemandXLagSpacing";
            SelectedAlertsIndex = 0;
            SelectedSettingsIndex = 0;

        }

        /// OnAlerted (event) - Jacob Monger
        /// <summary>
        /// adds or removes flag stating if alert limit was excided 
        /// </summary>
        /// <param name="source"> alert view model.</param>
        /// <param name="e"> data structure see alert view model.</param>
        public void OnAlerted(object source, AlertEventArgs e)
        {
            if (e.NewAlert == true) // is there a new alert
            {
                for (int ListPosition = 0; ListPosition < AlertList.Count(); ListPosition++) 
                {
                    if (AlertList[ListPosition].AlertName == e.AlertName) // find alert limit
                    {
                        if (e.AlertName.Contains("Max"))
                        {
                            if (e.AlertValue > AlertList[ListPosition].Threshold || AlertList[ListPosition].ThresholdToDisplay == null) // if bigger up date
                            {
                                App.Current.Dispatcher.Invoke((Action)delegate
                                {
                                    AlertList.Remove(AlertList[ListPosition]);
                                    AlertList.Insert(ListPosition, new AlertListItemModel(e.AlertName, " (Exceeded ", e.AlertValue.ToString("0.00") + ")", e.AlertValue));
                                });
                            }
                        }
                        if (e.AlertName.Contains("Min"))
                        {
                            if (e.AlertValue < AlertList[ListPosition].Threshold || AlertList[ListPosition].ThresholdToDisplay == null) // if smaller upadte
                            {
                                App.Current.Dispatcher.Invoke((Action)delegate
                                {
                                    AlertList.Remove(AlertList[ListPosition]);
                                    AlertList.Insert(ListPosition, new AlertListItemModel(e.AlertName, " (Exceeded ", e.AlertValue.ToString("0.00") + ")", e.AlertValue));
                                });
                            }
                        }
                        return;
                    }
                }
            }
            else
            {
                for (int ListPosition = 0; ListPosition < AlertList.Count(); ListPosition++) // clear all flags
                {
                    if (AlertList[ListPosition].Exceeded != null)
                    {
                        string temporyName = AlertList[ListPosition].AlertName;
                        App.Current.Dispatcher.Invoke((Action)delegate
                        {
                            AlertList.Remove(AlertList[ListPosition]);
                            AlertList.Insert(ListPosition, new AlertListItemModel(temporyName));
                        });
                    }
                }
            }
        }

        private int _selectedSettingsIndex;
        public int SelectedSettingsIndex
        {
            get
            {
                return _selectedSettingsIndex;
            }
            set
            {
                if (value >= 0)
                {
                    try
                    {
                        _selectedSettingsIndex = value;
                        SelectIndexValue = SettingsList[value].SettingsName; // set selected setting
                        NewSettings = SettingsList[value].SettingsValue.ToString("0.00"); // set selected setting
                        OnPropertyChanged("SelectedSettingsIndex");
                    }
                    catch { }
                }
            }
        }

        /// UpdateSettings (command) - Jacob Monger
        /// <summary>
        /// if valid updates setting
        /// </summary>
        /// <param name="message"> user input</param>
        public void UpdateSettings(object message)
        {
            if (SelectedSettingsIndex != -1)
            {
                if (double.TryParse(message.ToString(), out double newValue))
                {
                        String SettingsName = SettingsList[SelectedSettingsIndex].SettingsName;
                        Properties.Settings.Default[SettingsName] = newValue;
                        Properties.Settings.Default.Save();
                        SettingsList.Remove(SettingsList[SelectedSettingsIndex]);
                        SettingsList.Insert(SelectedSettingsIndex, new SettingsListItemModel(SettingsName));
                }
            }
        }

        private int _selectedAlertsIndex;
        public int SelectedAlertsIndex
        {
            get
            {
                return _selectedAlertsIndex;
            }
            set
            {
                if (value >= 0)
                {
                    try
                    {
                        _selectedAlertsIndex = value;
                        SelectAlertValue = AlertList[value].AlertName; //set selected alert
                        NewAlert = AlertList[value].AlertValue.ToString("0.00"); // set selected alert
                        OnPropertyChanged("SelectedAlertsIndex");
                    }
                    catch { }
                }
            }
        }
        /// UpdateAlert (command) - Jacob Monger
        /// <summary>
        /// if valid updates setting, removes alert from alert list if flagged
        /// </summary>
        /// <param name="message"> user input</param>
        public void UpdateAlert(object message)
        {
            if (SelectedAlertsIndex != -1)
            {
                if (double.TryParse(message.ToString(), out double newValue))
                {
   
                        if (AlertList[SelectedAlertsIndex].ThresholdToDisplay != null)
                        {
                            AlertViewModelInstance.RemoveAlert(AlertList[SelectedAlertsIndex].AlertName);
                        }
                        String AlertName = AlertList[SelectedAlertsIndex].AlertName;
                        Properties.Settings.Default[AlertName] = newValue;//convert.ToDouble(null);
                        Properties.Settings.Default.Save();
                        AlertList.Remove(AlertList[SelectedAlertsIndex]);
                        AlertList.Insert(SelectedAlertsIndex, new AlertListItemModel(AlertName));
                    }
            }
        }
    }
}
