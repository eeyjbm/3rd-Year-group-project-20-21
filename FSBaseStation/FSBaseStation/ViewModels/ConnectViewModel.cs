using FSBaseStation.Commands;
using FSBaseStation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FSBaseStation.ViewModels
{
    /// ConnectViewModel - Jacob Monger
    /// <summary>
    /// view model for connect view - used to connect to com port as well as reading in data
    /// </summary>

    public class ConnectViewModel : ObservableObject
    {
        SerialPort ArduinoConnectedPort = new SerialPort(); //serial port object 
        public DashboardViewModel DashboardViewModelInstance { get; set; } //other sub view instances to allow data to be passed to them
        public ECUViewModel ECUViewModelInstance { get; set; }
        public KistlerViewModel KistlerViewModelInstance { get; set; }
        public LeftInverterViewModel LeftInverterViewModelInstance { get; set; }
        public RightInverterViewModel RightInverterViewModelInstance { get; set; }
        public TemperatureViewModel TemperatureViewModelInstance { get; set; }

        string DataLogPath; //path to data log folder
        string MyDocuments; //path to data log file
        public AlertViewModel AlertViewModelInstance { get; set; } //instance called to check alert values

        private string _connectionButtonConntent;  // button content
        public bool isConnected { get; private set; }
        public bool GaugeTab { get; set; }
        public RelayCommand SerialPortConnectCommand { get; private set; } // connect button command


        public delegate void DisconnectedEventHandler(object source, EventArgs args); // on disconnect event
        public event DisconnectedEventHandler Disconnected;

        private string[] _availablePorts;
        public string[] AvailablePorts //list of avaliable com port
        {
            get
            {
                return _availablePorts;
            }
            set
            {
                _availablePorts = value;
                OnPropertyChanged("AvailablePorts");
            }
        }

        public string ConnectionButtonConntent // button content
        {

            get
            {
                return _connectionButtonConntent;
            }
            set
            {
                _connectionButtonConntent = value;
                OnPropertyChanged("ConnectionButtonConntent");
            }
        }

        private string _info;
        public string Info //info string about conection status
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_info))
                    return "Unknown";

                return _info;
            }
            set
            {
                _info = value;
                OnPropertyChanged("Info");
            }
        }
        /// AlertViewModel (Constructor)- Jacob Monger
        /// <summary>
        /// gets path to data log folder, initalizes variables, sets up commands, sub subscribes to RX event and sets up timed event
        /// </summary>
        public ConnectViewModel()
        {
            MyDocuments = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FSBaseStation_DataLog"); // get path too data log folder
            _connectionButtonConntent = "Connect"; 
            isConnected = false;
            GaugeTab = false;
            SerialPortConnectCommand = new RelayCommand(ConnectToSerialPort); // connect button commmand
             
            ArduinoConnectedPort.DataReceived += rx_data_event; // serial data event

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); // timed event set up
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500); // ever 500 ms
            dispatcherTimer.Start();
        }

        /// dispatcherTimer_Tick(event) - Jacob Monger
        /// <summary>
        /// Timed event fired every 500 ms. Updates port name selection, checks if disconneced 
        /// </summary>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            AvailablePorts = SerialPort.GetPortNames();


            if (!ArduinoConnectedPort.IsOpen || AvailablePorts.Length == 0)
            {
                ArduinoConnectedPort.Close();
                ConnectionButtonConntent = "Connect";
                Info = $"Disconnected from COM port";
                if (isConnected != false)
                     OnDisconnected();
                isConnected = false;

            }
        }

        /// OnDisconnected (event)- Jacob Monger
        /// <summary>
        /// subscibed to from main window, causes sub view to be set to connect view
        /// </summary>
        protected virtual void OnDisconnected()
        {
            if (Disconnected != null)
                Disconnected(this, EventArgs.Empty);
        }

        /// ConnectToSerialPort (command)- Jacob Monger
        /// <summary>
        /// tries to either connect or disconnect to com port
        /// </summary>
        /// <param name="message"> sellected port </param>
        public void ConnectToSerialPort(object message)
        {
            if (!ArduinoConnectedPort.IsOpen) // is port open
            {
                try
                {
                    ArduinoConnectedPort.BaudRate = 9600; // paramiters
                    ArduinoConnectedPort.DataBits = 8;
                    ArduinoConnectedPort.Handshake = Handshake.None;
                    ArduinoConnectedPort.Parity = Parity.None;
                    ArduinoConnectedPort.StopBits = StopBits.One;
                }
                catch 
                {
                    return;
                }
                try
                {
                    if ((string)message != null)
                    {
                        ArduinoConnectedPort.PortName = (string)message; // selected port name 
                    }
                }
                catch 
                {
                    return;
                }
                try
                {
                    if (!ArduinoConnectedPort.IsOpen) //double precaution 
                    {
                        try
                        {
                            ArduinoConnectedPort.Open(); // open connection
                            ConnectionButtonConntent = "Disconnect";
                            Info = $"Connected to {(string)message} ";

                            isConnected = true;
                            string convert = DateTime.Now.ToString(); 
                            convert = convert.Replace('/', '_');
                            convert = convert.Replace(':', '.');
                            DataLogPath = System.IO.Path.Combine(MyDocuments, "Log " + convert + ".txt"); //create data log file name 
                            ArduinoConnectedPort.DiscardInBuffer();
                        }
                        catch 
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            ArduinoConnectedPort.Close(); //close connection
                            ConnectionButtonConntent = "Connect";
                            Info = $"Disconnected from COM port";

                            isConnected = false;

                        }
                        catch 
                        {
                        }
                    }
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    ArduinoConnectedPort.Close(); // close connection
                    ConnectionButtonConntent = "Connect";
                    Info = $"Disconnected from COM port";
                    isConnected = false;

                }
                catch 
                {
                }
            }

        }


        /// ConnectToSerialPort (event)- Jacob Monger
        /// <summary>
        /// reads in data, logs data, checks if limits excided and update graphs
        /// </summary>
        /// <param name="sender"> sellected port </param>
        private void rx_data_event(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            SerialPort dataIn = sender as SerialPort; //serial port
            if (dataIn.IsOpen)
            {
                string data = "-";
                try
                {
                    data = dataIn.ReadLine(); //try to read in data
                }
                catch{}
            
                if (data.StartsWith("#")) 
                {
                    double CurrentValue;
                    data = data.Remove(0, 1); // remove #

                    if (1 == (int)Properties.Settings.Default.WriteToDataLog) //is data loging enabled
                    {
                        if (!Directory.Exists(MyDocuments)) //if folder isn't there
                        {
                            Directory.CreateDirectory(MyDocuments); // create
                        }
                        File.AppendAllText(DataLogPath, DateTime.Now + " ---> " + data); // create/ append to file
                    }

                    try 
                    {
                        string[] variables = data.Split(','); //split up data

                        CurrentValue = Convert.ToDouble(variables[0]);
                        ECUViewModelInstance.Graph1Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("ECULeftTorqueDemand", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[1]);
                        ECUViewModelInstance.Graph2Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("ECURightTorqueDemand", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[2]);
                        ECUViewModelInstance.Graph3Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("ECUAcclerationDemand", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[3]);
                        ECUViewModelInstance.Graph4Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("ECUFrontBrakeDemand", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[4]);
                        KistlerViewModelInstance.Graph1Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("KistlerVelX", CurrentValue);
                        if (GaugeTab) //only up date graphs if active tab
                            DashboardViewModelInstance.KistlerVelX = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[5]);
                        KistlerViewModelInstance.Graph2Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("KistlerVelY", CurrentValue);
                        if (GaugeTab)
                            DashboardViewModelInstance.KistlerVelY = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[6]);
                        KistlerViewModelInstance.Graph3Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("KistlerAcclerationX", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[7]);
                        KistlerViewModelInstance.Graph4Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("KistlerAcclerationX", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[8]);
                        LeftInverterViewModelInstance.Graph1Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("LeftInverterSpeed", CurrentValue);
                        if (GaugeTab)
                            DashboardViewModelInstance.LeftInverterSpeed = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[9]);
                        LeftInverterViewModelInstance.Graph2Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("LeftInverterMechanicalPower", CurrentValue);
                        if (GaugeTab)
                            DashboardViewModelInstance.LeftInverterMechanicalPower = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[10]);
                        LeftInverterViewModelInstance.Graph3Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("LeftInverterAbsolutePhaseCurrent", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[11]);
                        LeftInverterViewModelInstance.Graph4Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("LeftInverterLinkVoltageDC", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[12]);
                        RightInverterViewModelInstance.Graph1Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("RightInverterSpeed", CurrentValue);
                        if (GaugeTab)
                            DashboardViewModelInstance.RightInverterSpeed = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[13]);
                        RightInverterViewModelInstance.Graph2Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("RightInverterMechanicalPower", CurrentValue);
                        if (GaugeTab)
                            DashboardViewModelInstance.RightInverterMechanicalPower = CurrentValue;

                        CurrentValue = Convert.ToDouble(variables[14]);
                        RightInverterViewModelInstance.Graph3Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("RightInverterAbsolutePhaseCurrent", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[15]);
                        RightInverterViewModelInstance.Graph4Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("RightInverterLinkVoltageDC", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[16]);
                        TemperatureViewModelInstance.Graph1Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("RightPCBTemp", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[17]);
                        TemperatureViewModelInstance.Graph2Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("LeftPCBTemp", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[18]);
                        TemperatureViewModelInstance.Graph3Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("TotalAverageBatteryTemp", CurrentValue);

                        CurrentValue = Convert.ToDouble(variables[19]);
                        TemperatureViewModelInstance.Graph4Value = CurrentValue;
                        AlertViewModelInstance.NewAlert("GearBoxTemp", CurrentValue);
                    }
                    catch { }


                        Task.Factory.StartNew(ECUViewModelInstance.AddPoints); //add points to graphs
                        Task.Factory.StartNew(KistlerViewModelInstance.AddPoints);
                        Task.Factory.StartNew(LeftInverterViewModelInstance.AddPoints);
                        Task.Factory.StartNew(RightInverterViewModelInstance.AddPoints);
                        Task.Factory.StartNew(TemperatureViewModelInstance.AddPoints);
                    
                }
                try
                {
                    dataIn.DiscardInBuffer(); //clear graph
                }
                catch { }
                
            }

        }
    }
}
