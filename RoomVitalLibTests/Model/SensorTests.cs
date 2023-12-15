using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model.Tests
{
    [TestClass()]
    public class SensorTests
    {
        private Sensor sensor1 = new Sensor(temperatur = 50, luftfugtighed = 50);

        public static int temperatur { get; private set; }
        public static int luftfugtighed { get; private set; }

        [TestMethod()]
        public void SensorTest()
        {
            int expectedTemperatur = 25;
            int expectedLuftfugtighed = 50;


            Sensor sensor = new Sensor(expectedTemperatur, expectedLuftfugtighed);


            Assert.AreEqual(expectedTemperatur, sensor.Temperatur, "Temperatur is not set correctly by the constructor.");
            Assert.AreEqual(expectedLuftfugtighed, sensor.Luftfugtighed, "Luftfugtighed is not set correctly by the constructor.");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string str = sensor1.ToString();
            Assert.AreEqual("{Temperatur=50, Luftfugtighed=50}", str);
        }


    }
}