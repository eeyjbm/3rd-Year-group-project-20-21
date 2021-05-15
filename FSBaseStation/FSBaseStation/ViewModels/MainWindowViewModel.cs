using FSBaseStation.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.ViewModels
{
    /// MainWindowViewModel- Jacob Monger
    /// <summary>
    /// MainWindow ViewModel - main viewmodel for aplication which controls the selected sub view
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {

        public ConnectViewModel ConnectViewModelInstance = new ConnectViewModel();  //create sub views view models
        public DashboardViewModel DashboardViewModelInstance = new DashboardViewModel();
        public SettingsViewModel SettingsViewModelInstance = new SettingsViewModel();
        public AlertViewModel AlertViewModelInstance = new AlertViewModel();
        public ECUViewModel ECUViewModelInstance = new ECUViewModel();
        public KistlerViewModel KistlerViewModelInstance = new KistlerViewModel();
        public RightInverterViewModel RightInverterViewModelInstance = new RightInverterViewModel();
        public LeftInverterViewModel LeftInverterViewModelInstance = new LeftInverterViewModel();
        public TemperatureViewModel TemperatureViewModelInstance = new TemperatureViewModel();


        public RelayCommand AlertViewCommand { get; private set; } 
        public RelayCommand DashboardViewCommand { get; private set; } // side button commands
        public RelayCommand ConnectViewCommand { get; private set; }
        public RelayCommand SettingsViewCommand { get; private set; }
        public RelayCommand ECUViewCommand { get; private set; }
        public RelayCommand KistlerViewCommand { get; private set; }
        public RelayCommand TemperatureViewCommand { get; private set; }
        public RelayCommand RightInverterViewCommand { get; private set; }
        public RelayCommand LeftInverterViewCommand { get; private set; }

        private string _windowTitle;
        public string WindowTitle
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_windowTitle))
                    return "Connection";
                return _windowTitle;
            }
            set
            {
                _windowTitle = value;
                OnPropertyChanged("WindowTitle");
            }
        }

        private object _windowContent;
        public object WindowContent
        {
            get
            {
                return _windowContent;
            }
            set
            {
                _windowContent = value;
                OnPropertyChanged("WindowContent");
            }
        }

        private string _alertStatus;
        public string AlertStatus
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_alertStatus))
                    return "DimGray";

                return _alertStatus;
            }
            set
            {
                _alertStatus = value;
                OnPropertyChanged("AlertStatus");
            }
        }

        private string _alertImage;
        public string AlertImage
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_alertImage))
                    return "Images/Exclamation_64.png";

                return _alertImage;
            }
            set
            {
                _alertImage = value;
                OnPropertyChanged("AlertImage");
            }
        }

        private String _dashboardVisibility;
        public String DashboardVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_dashboardVisibility))
                    return "Hidden";
                return _dashboardVisibility;
            }
            set
            {

                _dashboardVisibility = value;
                OnPropertyChanged("DashboardVisibility");
            }
        }

        private String _eCUVisibility;
        public String ECUVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_eCUVisibility))
                    return "Hidden";
                return _eCUVisibility;
            }
            set
            {

                _eCUVisibility = value;
                OnPropertyChanged("ECUVisibility");
            }
        }

        private String _kistlerVisibility;
        public String KistlerVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_kistlerVisibility))
                    return "Hidden";
                return _kistlerVisibility;
            }
            set
            {
                _kistlerVisibility = value;
                OnPropertyChanged("KistlerVisibility");
            }
        }

        private String _temperatureVisibility;
        public String TemperatureVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_temperatureVisibility))
                    return "Hidden";
                return _temperatureVisibility;
            }
            set
            {

                _temperatureVisibility = value;
                OnPropertyChanged("TemperatureVisibility");
            }
        }

        private String _rightInverterVisibility;
        public String RightInverterVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_rightInverterVisibility))
                    return "Hidden";
                return _rightInverterVisibility;
            }
            set
            {
                _rightInverterVisibility = value;
                OnPropertyChanged("RightInverterVisibility");
            }
        }

        private String _leftInverterVisibility;
        public String LeftInverterVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_leftInverterVisibility))
                    return "Hidden";
                return _leftInverterVisibility;
            }
            set
            {
                _leftInverterVisibility = value;
                OnPropertyChanged("LeftInverterVisibility");
            }
        }

        private String _connectVisibility;
        public String ConnectVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_connectVisibility))
                    return "Hidden";
                return _connectVisibility;
            }
            set
            {
                _connectVisibility = value;
                OnPropertyChanged("ConnectVisibility");
            }
        }

        private String _settingsVisibility;
        public String SettingsVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_settingsVisibility))
                    return "Hidden";
                return _settingsVisibility;
            }
            set
            {
                _settingsVisibility = value;
                OnPropertyChanged("SettingsVisibility");
            }
        }



        public MainWindowViewModel()
        {
            AlertViewCommand = new RelayCommand(AlertView, ViewCanChange); // commands
            DashboardViewCommand = new RelayCommand(DashboardView, ViewCanChange);
            ConnectViewCommand = new RelayCommand(ConnectView, ViewCanChange);
            SettingsViewCommand = new RelayCommand(SettingsView, ViewCanChange);
            ECUViewCommand = new RelayCommand(ECUView, ViewCanChange);
            KistlerViewCommand = new RelayCommand(KistlerView, ViewCanChange);
            TemperatureViewCommand = new RelayCommand(TemperatureView, ViewCanChange);
            RightInverterViewCommand = new RelayCommand(RightInverterView, ViewCanChange);
            LeftInverterViewCommand = new RelayCommand(LeftInverterView, ViewCanChange);

            ConnectViewModelInstance.DashboardViewModelInstance = DashboardViewModelInstance;
            ConnectViewModelInstance.AlertViewModelInstance = AlertViewModelInstance;
            ConnectViewModelInstance.ECUViewModelInstance = ECUViewModelInstance;
            ConnectViewModelInstance.KistlerViewModelInstance = KistlerViewModelInstance;
            ConnectViewModelInstance.LeftInverterViewModelInstance = LeftInverterViewModelInstance;
            ConnectViewModelInstance.RightInverterViewModelInstance = RightInverterViewModelInstance;
            ConnectViewModelInstance.TemperatureViewModelInstance = TemperatureViewModelInstance;

            SettingsViewModelInstance.AlertViewModelInstance = AlertViewModelInstance; 

            WindowContent = ConnectViewModelInstance; //sub view content 
            ConnectVisibility = "Visible";

            ConnectViewModelInstance.Disconnected += OnDisconnected; // events
            AlertViewModelInstance.Alert += OnAlerted;
            AlertViewModelInstance.Alert += SettingsViewModelInstance.OnAlerted;
            AlertViewModelInstance.UpdateSettings += OnUpdateSettings;
        }

        /// DashboardView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void DashboardView(object message)
        {
            WindowTitle = "Dashboard";
            WindowContent = DashboardViewModelInstance;
            ConnectViewModelInstance.GaugeTab = true;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            DashboardVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
        }

        /// ECUView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void ECUView(object message)
        {
            WindowTitle = "Engine Control Unit";
            WindowContent = ECUViewModelInstance;
            ECUViewModelInstance.CurrentTab = true;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            ECUViewModelInstance.ProcessGraphData(DateTime.Now); // update graphs
            ECUVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// KistlerView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void KistlerView(object message)
        {
            WindowTitle = "Kistler Unit";
            WindowContent = KistlerViewModelInstance;
            KistlerViewModelInstance.CurrentTab = true;
            ECUViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.ProcessGraphData(DateTime.Now);
            KistlerVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// TemperatureView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void TemperatureView(object message)
        {
            WindowTitle = "Temperature";
            WindowContent = TemperatureViewModelInstance;
            TemperatureViewModelInstance.CurrentTab = true;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.ProcessGraphData(DateTime.Now);
            TemperatureVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// RightInverterView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>

        public void RightInverterView(object message)
        {
            WindowTitle = "Right Inverter";
            WindowContent = RightInverterViewModelInstance;
            RightInverterViewModelInstance.CurrentTab = true;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.ProcessGraphData(DateTime.Now);
            RightInverterVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// LeftInverterView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void LeftInverterView(object message)
        {
            WindowTitle = "Left Inverter";
            WindowContent = LeftInverterViewModelInstance;
            LeftInverterViewModelInstance.CurrentTab = true;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.ProcessGraphData(DateTime.Now);
            LeftInverterVisibility = "Visible";
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// ConnectView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void ConnectView(object message)
        {
            WindowTitle = "Connection";
            WindowContent = ConnectViewModelInstance;
            ConnectViewModelInstance.GaugeTab = false;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            ConnectVisibility = "Visible";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// SettingsView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void SettingsView(object message)
        {
            WindowTitle = "Settings";
            WindowContent = SettingsViewModelInstance;
            ConnectViewModelInstance.GaugeTab = false;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            SettingsVisibility = "Visible";
            ConnectVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }
        /// AlertView (command)- Jacob Monger
        /// <summary>
        /// changes sub view, changes title text, enables sub view and sets tab indicator to visible
        /// </summary>
        /// <param name="message"> null </param>
        public void AlertView(object message)
        {
            WindowTitle = "Alerts";
            WindowContent = AlertViewModelInstance;
            ConnectViewModelInstance.GaugeTab = false;
            ECUViewModelInstance.CurrentTab = false;
            KistlerViewModelInstance.CurrentTab = false;
            TemperatureViewModelInstance.CurrentTab = false;
            RightInverterViewModelInstance.CurrentTab = false;
            LeftInverterViewModelInstance.CurrentTab = false;
            ConnectVisibility = "Hidden";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }

        /// ViewCanChange (predicate)- Jacob Monger
        /// <summary>
        /// enables or disables side buttons depending on connection status
        /// </summary>
        /// <param name="message"> null </param>
        public bool ViewCanChange(object message)
        {
            return ConnectViewModelInstance.isConnected;
        }

        /// OnDisconnected (event)- Jacob Monger
        /// <summary>
        /// changes to connect view
        /// </summary>
        /// <param name="source"> null </param>
        /// <param name="e"> null </param>
        public void OnDisconnected(object source, EventArgs e)
        {
            WindowTitle = "Connection";
            WindowContent = ConnectViewModelInstance;
            ConnectVisibility = "Visible";
            SettingsVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
        }


        /// OnDisconnected (event)- Jacob Monger
        /// <summary>
        /// changes alert button colour to show if there is an alert
        /// </summary>
        /// <param name="source"> alert view model </param>
        /// <param name="e"> data structure - NewAlert = if theres a new alert</param>
        public void OnAlerted(object source, AlertEventArgs e)
        {
            if (e.NewAlert == true)
            {
                AlertStatus = "DarkRed";
                AlertImage = "Images/ExclamationMarkBlack_64.png";
            }
            else
            {
                AlertStatus = "DimGray";
                AlertImage = "Images/Exclamation_64.png";
            }
        }

        /// OnUpdateSettings (event)- Jacob Monger
        /// <summary>
        /// changes to settings sub view
        /// </summary>
        /// <param name="source"> alert view model </param>
        /// <param name="e"> null</param>
        public void OnUpdateSettings(object source, EventArgs e)
        {
            SettingsVisibility = "Visible";
            ConnectVisibility = "Hidden";
            ECUVisibility = "Hidden";
            KistlerVisibility = "Hidden";
            TemperatureVisibility = "Hidden";
            RightInverterVisibility = "Hidden";
            LeftInverterVisibility = "Hidden";
            DashboardVisibility = "Hidden";
            WindowContent = SettingsViewModelInstance;
        }


    }
}
