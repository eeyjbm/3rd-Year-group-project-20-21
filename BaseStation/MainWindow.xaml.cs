﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO.Ports;



namespace SideMenuListControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort ArduinoConnectedPort = new SerialPort();
                int MaxNumberOfItemsAllowed = 1000;

        public MainWindow()
        {
            InitializeComponent();
            ArduinoConnectedPort.DataReceived += Mainport_DataReceived;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += timer_Tick;
            timer.Start();

            //this is to set default page on application startup such as dashboard...etc..
            //  frame.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));


        }

        private void SideMenuControl_SelectionChanged(object sender, EventArgs e)
        {
            if (ArduinoConnectedPort.IsOpen)
            {
                availablePorts.Visibility = Visibility.Collapsed;
                connectbutton.Visibility = Visibility.Collapsed;
                received.Visibility = Visibility.Collapsed;
                title.Visibility = Visibility.Collapsed;
                switch (MenuList.SelectedIndex)
                {
                    case 0:
                        frame.Visibility = Visibility.Visible;
                        frame.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    case 1:
                        frame.Visibility = Visibility.Visible;
                        frame.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    case 2:
                        frame.Visibility = Visibility.Hidden;
                        availablePorts.ItemsSource = SerialPort.GetPortNames();
                        availablePorts.Visibility = Visibility.Visible;
                        connectbutton.Visibility = Visibility.Visible;
                        received.Visibility = Visibility.Visible;
                        title.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        frame.Visibility = Visibility.Visible;
                        frame.Navigate(new Uri("Settings.xaml", UriKind.RelativeOrAbsolute));
                        break;
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (!ArduinoConnectedPort.IsOpen)
            {
                connectbutton.Content = "Connect";
                availablePorts.ItemsSource = SerialPort.GetPortNames();
                availablePorts.Visibility = Visibility.Visible;
                connectbutton.Visibility = Visibility.Visible;
                received.Visibility = Visibility.Visible;
                title.Visibility = Visibility.Visible;

                frame.Visibility = Visibility.Hidden;
            }
        }

        private void Mainport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (ArduinoConnectedPort.IsOpen)
            {
                try
                {
                    Task.Factory.StartNew(() =>
                    {
                        //ReadLine() i think only returns the port's buffer if there's a '\n' on the very end. if it's in
                        //the middle... i dont think it gives one and ignores it, returning null.
                        //This whole method might fire 2 or 3 times, and only the last time will it actually add a message... i think.
                        WriteReceived($"[RX]> {ArduinoConnectedPort.ReadExisting()}");
                    });
                }
                catch (Exception g) { MessageBox.Show(g.Message, "Error receiving data on serial port"); }
            }
        }

        private void WriteReceived(string text)
        {
            //this makes writing to the received listbox easier and will clear if it has too many items
            //to decrease lag.
            Dispatcher.BeginInvoke(new Action(() =>
            {
                received.Items.Add(text);
                if (received.Items.Count >= MaxNumberOfItemsAllowed)
                {
                    received.Items.Clear();
                }
            }));
        }

        private void ConectToPort(object sender, RoutedEventArgs e)
        {

            if (!ArduinoConnectedPort.IsOpen)
            {
                try
                {
                    ArduinoConnectedPort.BaudRate = 9600;
                    ArduinoConnectedPort.DataBits = 8;
                    ArduinoConnectedPort.Handshake = Handshake.None; 
                    ArduinoConnectedPort.Parity = Parity.None;
                    ArduinoConnectedPort.StopBits = StopBits.One;
                }
                catch (Exception ggg)
                {
                    MessageBox.Show(ggg.Message, "Error defining variables for serial port");
                    return;
                }
                try
                {
                    if (availablePorts.SelectedItem != null)
                    {
                        ArduinoConnectedPort.PortName = availablePorts.SelectedItem.ToString();
                    }
                }
                catch (Exception ggg)
                {
                    MessageBox.Show(ggg.Message, "Error defining the portname for serial port");
                    return;
                }
                ///quite alot of try/catches but whatever ;)
                try
                {
                    if (!ArduinoConnectedPort.IsOpen) //double precaution ;)
                    {
                        try
                        {
                            ArduinoConnectedPort.Open();
                            connectbutton.Content = "Disconnect";
                            availablePorts.Visibility = Visibility.Collapsed;
                            connectbutton.Visibility = Visibility.Collapsed;
                            received.Visibility = Visibility.Collapsed;
                            title.Visibility = Visibility.Collapsed;

                            switch (MenuList.SelectedIndex)
                            {
                                case 0:
                                    frame.Visibility = Visibility.Visible;
                                    frame.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
                                    break;
                                case 1:
                                    frame.Visibility = Visibility.Visible;
                                    frame.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
                                    break;

                                case 2:
                                    frame.Visibility = Visibility.Hidden;
                                    availablePorts.ItemsSource = SerialPort.GetPortNames();
                                    availablePorts.Visibility = Visibility.Visible;
                                    connectbutton.Visibility = Visibility.Visible;
                                    received.Visibility = Visibility.Visible;
                                    title.Visibility = Visibility.Visible;

                                    break;
                                case 3:
                                    frame.Visibility = Visibility.Visible;
                                    frame.Navigate(new Uri("Settings.xaml", UriKind.RelativeOrAbsolute));
                                    break;
                            }
                        }
                        catch (Exception dfjfd)
                        {
                            MessageBox.Show(dfjfd.Message); return;
                        }
                    }
                    else
                    {
                        try
                        {
                            ArduinoConnectedPort.Close();
                            connectbutton.Content = "Connect";
                        }
                        catch (Exception dfjfd)
                        {
                            MessageBox.Show(dfjfd.Message);
                        }
                    }
                }
                catch (Exception gg)
                {
                    MessageBox.Show(gg.Message);
                }
            }
            else
            {
                try
                {
                    ArduinoConnectedPort.Close();
                    connectbutton.Content = "Connect";
                }
                catch (Exception dfjfd)
                {
                    MessageBox.Show(dfjfd.Message);
                }
            }
        }
    }
    

}
