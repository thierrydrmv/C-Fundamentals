﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.HR
{
    internal struct WorkTask
    {
        public string description;
        public int hours;
        public void PerformWorkTask()
        {
            Console.WriteLine($"Task \"{description}\" of {hours} hour(s) has been performed.");
        }
    }
}
