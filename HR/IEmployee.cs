﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.HR
{
    internal interface IEmployee
    {
        double ReceiveWage(bool restHours = true);
        void GiveBonus();
        void PerformWork(int numberOfHours);
        void DisplayEmployeeDetails();
        void GiveCompliment();
    }
}
