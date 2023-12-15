using RoomVitalLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model
{
    public class Sensor
    {
        public int Temperatur { get; }
        public int Luftfugtighed { get; }

        public Sensor(int temperatur, int luftfugtighed)
        {
            Temperatur = temperatur;
            Luftfugtighed = luftfugtighed;
        }

        public override string ToString()
        {
            return $"{{{nameof(Temperatur)}={Temperatur.ToString()}, {nameof(Luftfugtighed)}={Luftfugtighed.ToString()}}}";
        }
    }
}
