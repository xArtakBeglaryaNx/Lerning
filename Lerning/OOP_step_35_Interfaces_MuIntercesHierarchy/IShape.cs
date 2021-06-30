﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_35_Interfaces_MuIntercesHierarchy
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
