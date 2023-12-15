using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomVitalLib.Model;
using RoomVitalLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Repository.Tests
{
    [TestClass()]
    public class SensorRepositoryTests
    {
        [TestMethod()]
        public void GetCurrentHumidityTest()
        {
            var sensorRepository = new SensorRepository();
            int hum = sensorRepository.GetCurrentHumidity();
            int newhum=sensorRepository.GetCurrentHumidity();
            sensorRepository.UpdateHumidity(newhum);
            int updatehum = sensorRepository.GetCurrentHumidity();
            Assert.AreEqual(newhum, updatehum);
        }

        [TestMethod()]
        public void GetCurrentTemperaturTest()
        {
            var sensorRepository = new SensorRepository();
            int Temp = sensorRepository.GetCurrentTemperatur();
            int newTemp = Temp;
            sensorRepository.UpdateTemperatur(newTemp);
            int updatedTemp = sensorRepository.GetCurrentTemperatur();
            Assert.AreEqual(newTemp, updatedTemp);
        }

        [TestMethod()]
        public void UpdateHumidityTest()
        {

            var sensorRepository = new SensorRepository();
            int Hum = sensorRepository.GetCurrentHumidity();
            int newhum = Hum ;
            sensorRepository.UpdateHumidity(newhum);
            int updatedhum = sensorRepository.GetCurrentHumidity();
            Assert.AreEqual(newhum, updatedhum);
        }

        [TestMethod()]
        public void UpdateTemperaturTest()
        {
            var sensorRepository = new SensorRepository();
            int temp = sensorRepository.GetCurrentTemperatur();
            int newtemp = temp;
            sensorRepository.UpdateTemperatur(newtemp);
            int updatetemp = sensorRepository.GetCurrentTemperatur();
            Assert.AreEqual(newtemp, updatetemp);

        }
    }
}