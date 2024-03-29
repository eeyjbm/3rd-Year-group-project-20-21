﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FSBaseStation
{
    class ViewModel
    {
        //To call resource dictionary in our codebehind
        ResourceDictionary dict = Application.LoadComponent(new Uri("/FSBaseStation;component/IconDictionary.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        //Source list for our Menu Items Listbox
        public List<MenuItemsData> ItemsList
        {
            get
            {
                return new List<MenuItemsData> {
                new MenuItemsData(){ PathData= (PathGeometry)dict["HomeIcon"], MenuText="Home" },
                new MenuItemsData(){ PathData = (PathGeometry)dict["TemperatureIcon"], MenuText="Temperatures" },
                new MenuItemsData(){ PathData = (PathGeometry)dict["ConnectionIcon"], MenuText="Connection" },
                new MenuItemsData(){ PathData = (PathGeometry)dict["SettingsIcon"], MenuText="Settings" }};
            }
        }
    }

    public class MenuItemsData
    {
        public PathGeometry PathData { get; set; }
        public bool IsItemSelected { get; set; }
        public string MenuText { get; set; }
    }
}