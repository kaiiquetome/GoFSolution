﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
