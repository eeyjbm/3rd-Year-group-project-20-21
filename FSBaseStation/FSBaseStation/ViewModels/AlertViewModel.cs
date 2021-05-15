using FSBaseStation.Commands;
using FSBaseStation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.ViewModels
{
    /// AlertEventArgs- Jacob Monger
    /// <summary>
    /// classed used as the OnAlerted event args
    /// </summary>
    public class AlertEventArgs : EventArgs
    {
        public bool NewAlert { get; set; }
        public string AlertName { get; set; }
        public double AlertValue { get; set; }
        /// AlertEventArgs (constructor)- Jacob Monger
        /// <summary>
        /// classed used as the OnAlerted event args
        /// </summary>
        /// <param name="newAlert"> bool true = new alert, false = clear alerts.</param>
        /// <param name="alertName"> name of selected alert.</param>
        /// <param name="alertValue"> name of selected alert.</param>
        public AlertEventArgs(bool newAlert, string alertName, double alertValue)
        {
            NewAlert = newAlert;
            AlertName = alertName;
            AlertValue = alertValue;
        }
    }
    /// AlertViewModel- Jacob Monger
    /// <summary>
    /// view model for alert view - used to display alerts if incoming data goes over thersold values 
    /// </summary>
    public class AlertViewModel : ObservableObject
    {
        public ObservableCollection<AlertDataModel> AlertDataList { get; } = new ObservableCollection<AlertDataModel>();
        public delegate void AlertEventHandler(object source, AlertEventArgs args);
        public event AlertEventHandler Alert;
        public delegate void UpdateSettingsEventHandler(object source, EventArgs args);
        public event AlertEventHandler UpdateSettings;
        public RelayCommand ResetAlertCommand { get; private set; }
        public RelayCommand UpdateSettingsCommand { get; private set; }


        /// AlertViewModel (Constructor)- Jacob Monger
        /// <summary>
        /// Sets up two buttons for ResetAlertCommand and UpdateSettingsCommand
        /// </summary>
        public AlertViewModel()
        {
            ResetAlertCommand = new RelayCommand(ResetAlertButton);
            UpdateSettingsCommand = new RelayCommand(UpdateSettingsButton);

        }

        /// NewAlert - Jacob Monger
        /// <summary>
        /// tests if incoming data is over/ under the threshold value. Also removes alerts from the bottom if the list if there are too many
        /// </summary>
        /// <param name="alert"> name of selected alert.</param>
        /// <param name="AlertValue"> value of incoming data.</param>
        public void NewAlert(string alert, double AlertValue)
        {
            string alertMax = alert + "Max";
            string alertMin = alert + "Min";
            double Threshold;

            IConvertible convert = Properties.Settings.Default[alertMax] as IConvertible;

            if (convert != null) // can be converted
            {
                Threshold = convert.ToDouble(null);

                if (AlertValue > Threshold) // if bigger add alert
                {
                    App.Current.Dispatcher.Invoke((Action)delegate
                    {
                        AlertDataList.Add(new AlertDataModel(alertMax, AlertValue, Threshold));
                    });
                    OnAlerted(true, alertMax, AlertValue); // nottify settings view model and main window view model
                }
            }

            convert = Properties.Settings.Default[alertMin] as IConvertible;

            if (convert != null)
            {
                Threshold = convert.ToDouble(null);
                if (AlertValue < Threshold) // if smaller add alert
                {
                    App.Current.Dispatcher.Invoke((Action)delegate
                    {
                        AlertDataList.Add(new AlertDataModel(alertMin, AlertValue, Threshold));
                    });
                    OnAlerted(true, alertMin, AlertValue); // nottify settings view model and main window view model
                }
            }

            //if there are too many list items remove from the bottom
            for (int counter = AlertDataList.Count; (int)Properties.Settings.Default.LenghtOfAlertList < counter; counter--)
            {
                App.Current.Dispatcher.Invoke((Action)delegate
                {
                    AlertDataList.Remove(AlertDataList[0]);
                });
            }
        }

        /// RemoveAlert - Jacob Monger
        /// <summary>
        /// removes specific alert from list (called when from settings view model when limit value updated)
        /// </summary>
        /// <param name="ToRemove"> name of changed alert limit</param>
        public void RemoveAlert(string ToRemove)
        {
            int NumberOfListItems = AlertDataList.Count;

            for (int index = NumberOfListItems; index-- > 0;) // counts from bottom as list becomes shorter if alert is removed
            {
                if (ToRemove == AlertDataList[index].Alert) // is the alert to be removed
                {
                    App.Current.Dispatcher.Invoke((Action)delegate // UI used different thread so deligate
                    {
                        AlertDataList.Remove(AlertDataList[index]); // remove
                    });
                }
            }
            if(AlertDataList.Count == 0) //if no alerts mainwindow view model changes the alert button colour
                OnAlerted(false, null, 0);
        }

        /// ResetAlertButton(command) - Jacob Monger
        /// <summary>
        /// removes all alerts and fires on alerted to reset mainwindow alert button background to default
        /// </summary>
        /// <param name="message"> null</param>
        public void ResetAlertButton(object message)
        {
            App.Current.Dispatcher.Invoke((Action)delegate// UI used different thread so deligate
            {
                AlertDataList.Clear(); // remove all
            });
            OnAlerted(false, null, 0); //mainwindow view model changes the alert button colour
        }

        /// OnAlerted(event) - Jacob Monger
        /// <summary>
        /// fires on alerted event subscibed too from the main window and settings view models
        /// </summary>
        /// <param name="NewAlert"> bool true = new alert, false = clear alerts.</param>
        /// <param name="AlertName"> name of selected alert.</param>
        /// <param name="AlertValue"> name of selected alert.</param>
        protected virtual void OnAlerted(bool NewAlert, string AlertName, double AlertValue)
        {
            if (Alert != null)
                Alert(this, new AlertEventArgs(NewAlert, AlertName, AlertValue));
        }

        /// OnUpdateSettings(command) - Jacob Monger
        /// <summary>
        /// fires update settings event, causes main window view model to change sub view to settings
        /// </summary>
        protected virtual void OnUpdateSettings()
        {
            if (UpdateSettings != null)
                UpdateSettings(this, null);
        }

        /// UpdateSettingsButton(event) - Jacob Monger
        /// <summary>
        /// subscibed to from main window, causes sub view to be changed to settings sub view
        /// </summary>
        public void UpdateSettingsButton(object message)
        {
            OnUpdateSettings();
        }
    }
}
