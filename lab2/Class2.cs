﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
          : base(message)
        {

        }
    }
}