﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_29_ApplicationException_CustomException
{
    class Radio
    {
        public void TurnOn(bool turnOn)
        {
            Console.WriteLine(turnOn ? "You lesson top radio..." : "Radio crashed too...");
        }
    }
}
