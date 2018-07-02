using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    /// <summary>
    /// Class contains methods that given the raw data change to a proper unit.
    /// </summary>
    class AnalyzeData
    {
        /// <summary>
        /// Method changes raw data to properly scaled temperature value.
        /// </summary>
        /// <param name="temperatureData">Raw value of temperature.</param>
        /// <returns>
        /// Formatted temperature value.
        /// </returns>
        public double CalculateTemperature(double temperatureData)
        {
            int[] sss = new int[36000];
            Random rnd = new Random();
            for (int i = 0; i<sss.Length; i++)
            {
                sss[i] = rnd.Next(-4000, 4000);
            }
            return null;
        }
        /// <summary>
        /// Method changes raw data to properly scaled preassure value.
        /// </summary>
        /// <param name="preassureData">Raw value of preassure.</param>
        /// <returns>
        /// Formatted preassure value.
        /// </returns>
        public double CalculatePreassure(double preassureData)
        {
            return null;
        }
        /// <summary>
        /// Method changes raw data to properly scaled wind speed value.
        /// </summary>
        /// <param name="windSpeedData">Raw value of wind speed</param>
        /// <returns>
        /// Formatted wind speed value.
        /// </returns>
        public double CalculateWindSpeed(double windSpeedData)
        {
            return null;
        }
        /// <summary>
        /// Method changes raw data to properly scaled wind direction value.
        /// </summary>
        /// <param name="windDirectionData">Raw value of wind direction.</param>
        /// <returns>
        /// Formatted wind direction value.
        /// </returns>
        public double CalculateWindDirection(double windDirectionData)
        {
            return 0;
        }
        /// <summary>
        /// Method changes raw data to properly scaled rain level value.
        /// </summary>
        /// <param name="rainLevelData">Raw value of rain level.</param>
        /// <returns>
        /// Formatted rain level value.
        /// </returns>
        public double CalculateRainLevel(double rainLevelData)
        {
            return 0;
        }
    }
}
