﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exceptions
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
