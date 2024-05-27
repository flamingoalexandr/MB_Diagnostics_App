using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_Diagnostics_App.Models.Scenarios
{
    public class Scenario
    {
        public Dictionary<string, string> scenario;
        public Scenario()
        {
            scenario = new Dictionary<string, string>();
            scenario.Add("bios", "Осцилограф показывает активность");
            scenario.Add("RAM", "MemTestOK");
            scenario.Add("5V", "Мультиметр показывает 5.0V");
            scenario.Add("12V", "Мультиметр показывает 12.0V");
            scenario.Add("battery", "3.3V");
            scenario.Add("RTC", "0.277843V");
            scenario.Add("USB", "Напряжение колеблится от 0.45V до 0.55V");
        }




    }
}
    