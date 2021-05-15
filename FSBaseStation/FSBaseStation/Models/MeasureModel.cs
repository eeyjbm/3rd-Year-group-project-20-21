using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBaseStation.Models
{
    /// MeasureModel - Live charts (https://lvcharts.net/App/examples/v1/Wpf/Constant%20Changes)
    /// <summary>
    /// Used as data points for graphs
    /// </summary>
    public class MeasureModel
    {
        public DateTime DateTime { get; set; }
        public double Value { get; set; }
    }
}
