using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;
using System.Threading;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace POS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static Timer aTimer;
        public MainPage()
        {
            this.InitializeComponent();

            
            DispatcherTimer Timer = new DispatcherTimer();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AcquireSensorData acquireData = new AcquireSensorData();

            double temperature = acquireData.ReadTemperatureData();
            double preassure = acquireData.ReadPreassureData();
            double windSpeed = acquireData.ReadWindSpeedData();
            double windDirection = acquireData.ReadWindSpeedData();
            double rainLevel = acquireData.ReadRainLevelData();

            AnalyzeData analyzeData = new AnalyzeData();

            temperature = analyzeData.CalculateTemperature(temperature);
            preassure = analyzeData.CalculatePreassure(preassure);
            windSpeed = analyzeData.CalculateWindSpeed(windSpeed);
            windDirection = analyzeData.CalculateWindDirection(windDirection);
            rainLevel = analyzeData.CalculateRainLevel(rainLevel);

            ShowData(temperature, preassure, windSpeed, windDirection, rainLevel);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }
        void ShowData(double temperature, double preassure, double windSpeed, double windDirection, double rainLevel)
        {
            temperatureTextBlock.Text = Convert.ToString(temperature);
            preassureTextBlock.Text = Convert.ToString(preassure);
            windSpeedTextBlock.Text = Convert.ToString(windSpeed);
            windDirectionTextBlock.Text = Convert.ToString(windDirection);
            rainLevelTextBlock.Text = Convert.ToString(rainLevel);
        }
    }
}
