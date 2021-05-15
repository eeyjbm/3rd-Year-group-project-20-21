using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSBaseStation.Models;
using LiveCharts;
using LiveCharts.Configurations;

namespace FSBaseStation.ViewModels
{
    /// TemperatureViewModel - Jacob Monger
    /// <summary>
    /// data sub view view model to Temperature  - sets up and graphs data
    /// </summary>
    public class TemperatureViewModel : ObservableObject
    {
        private double _graph1AxisMax;
        private double _graph2AxisMax;
        private double _graph3AxisMax;
        private double _graph4AxisMax;

        private double _graph1AxisMin;
        private double _graph2AxisMin;
        private double _graph3AxisMin;
        private double _graph4AxisMin;

        private double _graph1AxisStep;
        private double _graph2AxisStep;
        private double _graph3AxisStep;
        private double _graph4AxisStep;


        public double Graph1Value { get; set; }
        public double Graph2Value { get; set; }
        public double Graph3Value { get; set; }
        public double Graph4Value { get; set; }
        public bool CurrentTab { get; set; }


        int Graph1Previous;
        int Graph2Previous;
        int Graph3Previous;
        int Graph4Previous;


        public TemperatureViewModel()
        {
            CurrentTab = false;
            var mapper = Mappers.Xy<MeasureModel>()
                   .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                   .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the values property will store our values array
            Graph1ChartValues = new ChartValues<MeasureModel>();
            Graph2ChartValues = new ChartValues<MeasureModel>();
            Graph3ChartValues = new ChartValues<MeasureModel>();
            Graph4ChartValues = new ChartValues<MeasureModel>();

            //lets set how to display the X Labels
            Graph1DateTimeFormatter = value => new DateTime((long)value).ToString("hh:mm:ss");
            Graph2DateTimeFormatter = value => new DateTime((long)value).ToString("hh:mm:ss");
            Graph3DateTimeFormatter = value => new DateTime((long)value).ToString("hh:mm:ss");
            Graph4DateTimeFormatter = value => new DateTime((long)value).ToString("hh:mm:ss");

            //AxisStep forces the distance between each separator in the X axis
            Graph1AxisStep = TimeSpan.FromSeconds(1).Ticks;
            Graph2AxisStep = TimeSpan.FromSeconds(1).Ticks;
            Graph3AxisStep = TimeSpan.FromSeconds(1).Ticks;
            Graph4AxisStep = TimeSpan.FromSeconds(1).Ticks;

            //AxisUnit forces lets the axis know that we are plotting seconds
            //this is not always necessary, but it can prevent wrong labeling
            Graph1AxisUnit = TimeSpan.TicksPerSecond;
            Graph2AxisUnit = TimeSpan.TicksPerSecond;
            Graph3AxisUnit = TimeSpan.TicksPerSecond;
            Graph4AxisUnit = TimeSpan.TicksPerSecond;

            ProcessGraphData(DateTime.Now);

        }

        public ChartValues<MeasureModel> Graph1ChartValues { get; set; }
        public ChartValues<MeasureModel> Graph2ChartValues { get; set; }
        public ChartValues<MeasureModel> Graph3ChartValues { get; set; }
        public ChartValues<MeasureModel> Graph4ChartValues { get; set; }

        public Func<double, string> Graph1DateTimeFormatter { get; set; }
        public Func<double, string> Graph2DateTimeFormatter { get; set; }
        public Func<double, string> Graph3DateTimeFormatter { get; set; }
        public Func<double, string> Graph4DateTimeFormatter { get; set; }

        public double Graph1AxisUnit { get; set; }
        public double Graph2AxisUnit { get; set; }
        public double Graph3AxisUnit { get; set; }
        public double Graph4AxisUnit { get; set; }

        public double Graph1AxisMax
        {
            get { return _graph1AxisMax; }
            set
            {
                _graph1AxisMax = value;
                OnPropertyChanged("Graph1AxisMax");
            }
        }

        public double Graph2AxisMax
        {
            get { return _graph2AxisMax; }
            set
            {
                _graph2AxisMax = value;
                OnPropertyChanged("Graph2AxisMax");
            }
        }
        public double Graph3AxisMax
        {
            get { return _graph3AxisMax; }
            set
            {
                _graph3AxisMax = value;
                OnPropertyChanged("Graph3AxisMax");
            }
        }
        public double Graph4AxisMax
        {
            get { return _graph4AxisMax; }
            set
            {
                _graph4AxisMax = value;
                OnPropertyChanged("Graph4AxisMax");
            }
        }
        public double Graph1AxisMin
        {
            get { return _graph1AxisMin; }
            set
            {
                _graph1AxisMin = value;
                OnPropertyChanged("Graph1AxisMin");
            }
        }
        public double Graph2AxisMin
        {
            get { return _graph2AxisMin; }
            set
            {
                _graph2AxisMin = value;
                OnPropertyChanged("Graph2AxisMin");
            }
        }
        public double Graph3AxisMin
        {
            get { return _graph3AxisMin; }
            set
            {
                _graph3AxisMin = value;
                OnPropertyChanged("Graph3AxisMin");
            }
        }
        public double Graph4AxisMin
        {
            get { return _graph4AxisMin; }
            set
            {
                _graph4AxisMin = value;
                OnPropertyChanged("Graph4AxisMin");
            }
        }

        public double Graph1AxisStep
        {
            get { return _graph1AxisStep; }
            set
            {
                _graph1AxisStep = value;
                OnPropertyChanged("Graph1AxisStep");
            }
        }
        public double Graph2AxisStep
        {
            get { return _graph2AxisStep; }
            set
            {
                _graph2AxisStep = value;
                OnPropertyChanged("Graph2AxisStep");
            }
        }
        public double Graph3AxisStep
        {
            get { return _graph3AxisStep; }
            set
            {
                _graph3AxisStep = value;
                OnPropertyChanged("Graph3AxisStep");
            }
        }
        public double Graph4AxisStep
        {
            get { return _graph4AxisStep; }
            set
            {
                _graph4AxisStep = value;
                OnPropertyChanged("Graph4AxisStep");
            }
        }
        /// AddPoints- Jacob Monger
        /// <summary>
        /// add points to graphs, done by seperate thread
        /// </summary>
        public void AddPoints()
        {
            var now = DateTime.Now;

            Graph1ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Graph1Value
            });

            Graph2ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Graph2Value
            });

            Graph3ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Graph3Value
            });

            Graph4ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Graph4Value
            });
            //itterativly remove data if required
            for (int counter = Graph1ChartValues.Count; (int)Properties.Settings.Default.RightPCBTempXNofDataPoint < counter; counter--)
            {
                Graph1ChartValues.RemoveAt(0);
            }
            for (int counter = Graph2ChartValues.Count; (int)Properties.Settings.Default.LeftPCBTempXNofDataPoint < counter; counter--)
            {
                Graph2ChartValues.RemoveAt(0);
            }
            for (int counter = Graph3ChartValues.Count; (int)Properties.Settings.Default.TotalAverageBatteryTempXNofDataPoint < counter; counter--)
            {
                Graph3ChartValues.RemoveAt(0);
            }
            for (int counter = Graph4ChartValues.Count; (int)Properties.Settings.Default.GearBoxTempXNofDataPoint < counter; counter--)
            {
                Graph4ChartValues.RemoveAt(0);
            }

            if (CurrentTab)
                ProcessGraphData(now);
        }
        /// ProcessGraphData - Jacob Monger
        /// <summary>
        /// various graph scaling and setup - only performend if it's the current sub view 
        /// </summary>
        /// <param name="now"> The current time </param>
        public void ProcessGraphData(DateTime now)
        {
            if (Properties.Settings.Default.RightPCBTempXLag != Graph1Previous)
            {
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.RightPCBTempXLag > Properties.Settings.Default.RightPCBTempXLagMax)
            {
                Properties.Settings.Default.RightPCBTempXLag = (int)Properties.Settings.Default.RightPCBTempXLagMax;
                Properties.Settings.Default.Save();
            }
            Graph1Previous = Properties.Settings.Default.RightPCBTempXLag;
            Graph1AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            Graph1AxisMin = now.Ticks - TimeSpan.FromSeconds(Graph1Previous).Ticks;
            Graph1AxisStep = TimeSpan.FromSeconds((double)Graph1Previous / Properties.Settings.Default.RightPCBTempXLagSpacing).Ticks;

            if (Properties.Settings.Default.LeftPCBTempXLag != Graph2Previous)
            {
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.LeftPCBTempXLag > Properties.Settings.Default.LeftPCBTempXLagMax)
            {
                Properties.Settings.Default.LeftPCBTempXLag = (int)Properties.Settings.Default.LeftPCBTempXLagMax;
                Properties.Settings.Default.Save();
            }
            Graph2Previous = Properties.Settings.Default.LeftPCBTempXLag;
            Graph2AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            Graph2AxisMin = now.Ticks - TimeSpan.FromSeconds(Graph2Previous).Ticks;
            Graph2AxisStep = TimeSpan.FromSeconds((double)Graph2Previous / Properties.Settings.Default.LeftPCBTempXLagSpacing).Ticks;

            if (Properties.Settings.Default.TotalAverageBatteryTempXLag != Graph3Previous)
            {
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.TotalAverageBatteryTempXLag > Properties.Settings.Default.TotalAverageBatteryTempXLagMax)
            {
                Properties.Settings.Default.TotalAverageBatteryTempXLag = (int)Properties.Settings.Default.TotalAverageBatteryTempXLagMax;
                Properties.Settings.Default.Save();
            }
            Graph3Previous = Properties.Settings.Default.TotalAverageBatteryTempXLag;
            Graph3AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            Graph3AxisMin = now.Ticks - TimeSpan.FromSeconds(Graph3Previous).Ticks;
            Graph3AxisStep = TimeSpan.FromSeconds((double)Graph3Previous / Properties.Settings.Default.TotalAverageBatteryTempXLagSpacing).Ticks;

            if (Properties.Settings.Default.GearBoxTempXLag != Graph4Previous)
            {
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.GearBoxTempXLag > Properties.Settings.Default.GearBoxTempXLagMax)
            {
                Properties.Settings.Default.GearBoxTempXLag = (int)Properties.Settings.Default.GearBoxTempXLagMax;
                Properties.Settings.Default.Save();
            }
            Graph4Previous = Properties.Settings.Default.GearBoxTempXLag;
            Graph4AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            Graph4AxisMin = now.Ticks - TimeSpan.FromSeconds(Graph4Previous).Ticks;
            Graph4AxisStep = TimeSpan.FromSeconds((double)Graph4Previous / Properties.Settings.Default.GearBoxTempXLagSpacing).Ticks;

          
        }
    }
}
