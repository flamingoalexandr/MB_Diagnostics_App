using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_Diagnostics_App.Models.MBComponents
{
    internal class Connector24pin
    {
        public bool Voltage3_3;
        public bool Voltage5;
        public bool Voltage12;
        public Connector24pin()
        {
            this.Voltage3_3 = false;
            this.Voltage5 = false;
            this.Voltage12 = false;
        }
        public void changeVoltage3_3(bool value)
        {
            this.Voltage3_3 = value;
        }
        public void changeVoltage5(bool value)
        {
            this.Voltage5 = value;
        }
        public void changeVoltage12(bool value)
        {
            this.Voltage12 = value;
        }
    }
}
