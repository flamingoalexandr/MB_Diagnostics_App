using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            
            Pair other = (Pair) obj;
            return PointId1 == other.PointId1
                && PointId2 == other.PointId2;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (PointId1?.GetHashCode() ?? 0);
                hash = hash * 23 + (PointId2?.GetHashCode() ?? 0);
                return hash;
            }
        }   
    }
}
