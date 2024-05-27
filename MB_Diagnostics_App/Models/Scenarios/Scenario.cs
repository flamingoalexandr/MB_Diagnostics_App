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
        public string name;
        public Scenario()
        {
            name = "Рабочая плата";
            scenario = new Dictionary<string, string>();
            scenario.Add("bios", "Осцилограф показывает активность");
            scenario.Add("RAM", "MemTestOK");
            scenario.Add("5V", "Мультиметр показывает 5.0V");
            scenario.Add("12V", "Мультиметр показывает 12.0V");
            scenario.Add("battery", "3.3V");
            scenario.Add("RTC", "0.277843V");
            scenario.Add("USB", "Напряжение колеблится от 0.45V до 0.55V");
            scenario.Add("Start", "Компьютер запускается");
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetBiosStatement(string statement)
        {
            scenario["bios"] = statement;
        }
        public void SetRAMStatement(string statement)
        {
            scenario["RAM"] = statement;
        }
        public void Set5VStatement(string statement)
        {
            scenario["5V"] = statement;
        }
        public void Set12VStatement(string statement)
        {
            scenario["12V"] = statement;
        }       
        public void SetBatteryStatement(string statement)
        {
            scenario["battery"] = statement;
        }
        public void SetRTCStatement(string statement)
        {
            scenario["RTC"] = statement;
        }
        public void SetUSBStatement(string statement)
        {
            scenario["USB"] = statement;
        }
        public void SetStartStatement(string statement)
        {
            scenario["Start"] = statement;
        }



    }
}
    