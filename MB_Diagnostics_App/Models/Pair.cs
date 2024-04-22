using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_Diagnostics_App.Models
{
    internal class Pair
    {              
        public string PointId1;
        public string PointId2;
        public Pair(string pId1, string pId2)
        {
            this.PointId1 = pId1;
            this.PointId2 = pId2;
        }
    }
}
