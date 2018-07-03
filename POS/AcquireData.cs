using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    /// <summary>
    /// Class that uses different methods to acquire data from multiple sensors
    /// </summary>
    public class AcquireSensorData
    {
        /// <summary>
        /// Method that connects with temperature sensor and saves value that it returns in a variable.
        /// </summary>
        /// <returns>
        /// Raw value of temperature.
        /// </returns>
        
        /// <summary>
        /// Method that connects with preassure sensor and saves value that it returns in a variable.
        /// </summary>
        /// <returns>
        /// Raw value of preassure.
        /// </returns>
        public double ReadPreassureData()
        {
            return 0;
        }
        /// <summary>
        /// Method that connects with wind sensor and saves value that it returns in a variable.
        /// </summary>
        /// <returns>
        /// Raw value of wind speed.
        /// </returns>
        public double ReadWindSpeedData()
        {
            return 0;
        }
        /// <summary>
        /// Method that connects with wind sensor and saves value that it returns in a variable.
        /// </summary>
        /// <returns>
        /// Raw value of wind direction.
        /// </returns>
        public double ReadWindDirectionData()
        {
            return 0;
        }
        /// <summary>
        /// Method that connects with rain level sensor and saves value that it returns in a variable.
        /// </summary>
        /// <returns>
        /// Raw value of rain level.
        /// </returns>
        public double ReadRainLevelData()
        {
            return 0;
        }
    }
}
