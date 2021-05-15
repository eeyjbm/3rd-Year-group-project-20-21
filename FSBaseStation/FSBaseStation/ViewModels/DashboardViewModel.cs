using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Configurations;

namespace FSBaseStation.ViewModels
{
    /// DashboardViewModel - Jacob Monger
    /// <summary>
    /// data sub view view model to gauge key values
    /// </summary>
    public class DashboardViewModel : ObservableObject
    {
        private double _kistlerVelX;
        public double KistlerVelX
        {
            get
            {
                return _kistlerVelX;
            }
            set
            {
                _kistlerVelX = value;
                OnPropertyChanged("KistlerVelX");
            }
        }

        private double _kistlerVelY;
        public double KistlerVelY
        {
            get
            {
                return _kistlerVelY;
            }
            set
            {
                _kistlerVelY = value;
                OnPropertyChanged("KistlerVelY");
            }
        }
        private double _rightInverterSpeed;
        public double RightInverterSpeed
        {
            get
            {
                return _rightInverterSpeed;
            }
            set
            {
                _rightInverterSpeed = value;
                OnPropertyChanged("RightInverterSpeed");
            }
        }

        private double _leftInverterSpeed;
        public double LeftInverterSpeed
        {
            get
            {
                return _leftInverterSpeed;
            }
            set
            {
                _leftInverterSpeed = value;
                OnPropertyChanged("LeftInverterSpeed");
            }
        }

        private double _rightInverterMechanicalPower;
        public double RightInverterMechanicalPower
        {
            get
            {
                return _rightInverterMechanicalPower;
            }
            set
            {
                _rightInverterMechanicalPower = value;
                OnPropertyChanged("RightInverterMechanicalPower");
            }
        }
        private double _leftInverterMechanicalPower;

        public double LeftInverterMechanicalPower
        {
            get
            {
                return _leftInverterMechanicalPower;
            }
            set
            {
                _leftInverterMechanicalPower = value;
                OnPropertyChanged("LeftInverterMechanicalPower");
            }
        }
        public DashboardViewModel() 
        {

        }
    }
}
