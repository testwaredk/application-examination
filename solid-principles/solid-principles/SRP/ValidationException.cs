﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.SRP
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
}