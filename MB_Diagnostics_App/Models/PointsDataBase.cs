using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace MB_Diagnostics_App.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.Pkcs;

class PointsDataBase
{
    public Dictionary<Pair, string> DB_for_multimetr = new Dictionary<Pair, string>();
    public string usb1 = "usb1";
    public string usb2 = "usb2";
    public string usb3 = "usb3";
    public string usb4 = "usb4";
    public string usb5 = "usb5";
    public string usb6 = "usb6";
    public string usb7 = "usb7";
    public string usb8 = "usb8";
    public string usb9 = "usb9";
    public string GND = "GND";
    //public Pair p1;
    public PointsDataBase()
    {
        //p1 = new Pair(usb1, usb2);
        DB_for_multimetr.Add(new Pair(usb1, usb2), "Звенит");
        DB_for_multimetr.Add(new Pair(usb1, usb3), "Звенит");
        DB_for_multimetr.Add(new Pair(usb1, usb9), "Звенит");
        DB_for_multimetr.Add(new Pair(usb1, GND), "Звенит");
    }
    public List<string> GetPointList()
    {
        List<string> l = new List<string>();
        l.Add(usb1);
        l.Add(usb2);
        l.Add(usb3);
        l.Add(usb4);
        l.Add(usb5);
        l.Add(usb6);
        l.Add(usb7);
        l.Add(usb8);
        l.Add(usb9);
        l.Add(GND);
        return l;
    }
    public string GetMeasurements(Pair pair)
    {
        return DB_for_multimetr[pair];
    }
}
