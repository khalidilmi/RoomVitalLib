using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Repository
{
    public class SensorRepository : ISensorRepository
    {
        private int _currentTemp;
        private int _currentHum;

        public int GetCurrentHumidity()
        {
            return _currentHum;
        }

        public int GetCurrentTemperatur()
        {
            return _currentTemp;
        }

        public void UpdateHumidity(int humidity)
        {
            _currentHum = humidity;
        }

        public void UpdateTemperatur(int temperatur)
        {
            _currentTemp = temperatur;
        }
    }
}
