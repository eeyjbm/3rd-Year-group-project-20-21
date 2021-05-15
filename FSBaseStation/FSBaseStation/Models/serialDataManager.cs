using FSBaseStation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.Models
{
    public class serialDataManager
    {
        public DashboardViewModel DashboardViewModelInstance { get; set; }
        public ECUViewModel ECUViewModelInstance { get; set; }
        public AlertViewModel AlertViewModelInstance { get; set; }
        public void splitData(string data)
        {
            double CurrentValue;
            data = data.Remove(0, 1);
            string[] variables = data.Split(',');

            CurrentValue = Convert.ToDouble(variables[0]);
            DashboardViewModelInstance.VelX = CurrentValue;
            ECUViewModelInstance.Data = CurrentValue;

                    AlertViewModelInstance.NewAlert("VelX", CurrentValue);

            //  if (CurrentValue > Properties.Settings.Default.VelXMax)
            //  {
            //        AlertViewModelInstance.NewAlert("VelXMax", CurrentValue, Properties.Settings.Default.VelXMax);
            //    }
            //   if (CurrentValue < Properties.Settings.Default.VelXMin)
            //   {
            //        AlertViewModelInstance.NewAlert("VelXMin", CurrentValue, Properties.Settings.Default.VelXMin);
            //   }

            CurrentValue = Convert.ToDouble(variables[1]);
            DashboardViewModelInstance.VelY = CurrentValue;
            AlertViewModelInstance.NewAlert("VelY", CurrentValue);

            //    if (CurrentValue > Properties.Settings.Default.VelYMax)
            //    {
            //        AlertViewModelInstance.NewAlert("VelYMax", CurrentValue, Properties.Settings.Default.VelYMax);
            //    }
            //    if (CurrentValue < Properties.Settings.Default.VelYMin)
            //    {
            //        AlertViewModelInstance.NewAlert("VelYMin", CurrentValue, Properties.Settings.Default.VelYMin);
            //    }
             }

            public void UpdateData()
        {
              ECUViewModelInstance.AddPoint();
        }
    }
}
