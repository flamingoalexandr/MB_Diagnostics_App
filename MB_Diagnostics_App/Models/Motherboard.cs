using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB_Diagnostics_App.Models.MBComponents;

namespace MB_Diagnostics_App.Models
{
    internal class Motherboard
    {
        public BIOSchip BIOS;
        public SouthBridge sb;
        public Connector24pin connector24pin;
        public Motherboard()
        {
            this.BIOS = new BIOSchip();
            this.sb = new SouthBridge();
            this.connector24pin = new Connector24pin();
        }

    }
}
