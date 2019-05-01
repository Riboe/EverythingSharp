using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverythingSharp.Enums;

namespace EverythingSharp.Exceptions
{
    public class EverythingException : Exception
    {
        public Error ErrorCode { get; }

        public EverythingException(Error errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
