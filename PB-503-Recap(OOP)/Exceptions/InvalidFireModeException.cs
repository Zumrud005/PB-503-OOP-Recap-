using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Recap_OOP_.Exceptions
{
   public class InvalidFireModeException : Exception
    {
        public InvalidFireModeException() 
        {
        }

        public InvalidFireModeException(string? message) : base(message)
        {
        }
    }
}
