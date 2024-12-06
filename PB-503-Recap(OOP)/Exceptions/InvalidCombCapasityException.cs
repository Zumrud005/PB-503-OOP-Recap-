using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Recap_OOP_.Exceptions
{
    public class InvalidCombCapasityException : Exception
    {
        public InvalidCombCapasityException()
        {

        }

        public InvalidCombCapasityException(string? message) : base(message)
        {

        }
    }
}
