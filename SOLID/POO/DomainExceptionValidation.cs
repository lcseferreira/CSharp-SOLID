﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POO
{
    // Herda de Exception
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {

        }

        public static void When(bool hasError, string error)
        {
            if (hasError) throw new DomainExceptionValidation(error);
        }
    }
}
