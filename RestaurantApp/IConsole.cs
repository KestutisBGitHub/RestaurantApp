﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public interface IConsole
    {
        void WriteLine(string value);

        string ReadLine();
    }
}
