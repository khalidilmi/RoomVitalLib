using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Repository
{
    public interface ISensorRepository
    {
        public int GetCurrentTemperatur();
        public void UpdateTemperatur(int temperatur);
        public int GetCurrentHumidity();
        public void UpdateHumidity(int humidity);



    }
}
