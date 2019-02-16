using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XmlHomeWork
{
    public class Car
    {
        public string Mark { get; set; }
        public int AmoutGears { get; set; }
        public int MaxSpeed { get; set; }
        public Engine Engine { get; set; }
    }
}