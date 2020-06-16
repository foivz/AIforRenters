using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIForRentersLib.Exceptions
{
    public class LoginException : ApplicationException
    {
        public string ExceptionMessage { get; set; }

        public LoginException(string exceptionMessage)
        {
            ExceptionMessage = exceptionMessage;
        }
    }

    public class PropertyException : ApplicationException
    {
        public string ExceptionMessage { get; set; }

        public PropertyException(string exceptionMessage)
        {
            ExceptionMessage = exceptionMessage;
        }
    }

    public class UnitException : ApplicationException
    {
        public string ExceptionMessage { get; set; }

        public UnitException(string exceptionMessage)
        {
            ExceptionMessage = exceptionMessage;
        }
    }

    public class EmailTemplateException : ApplicationException
    {
        public string ExceptionMessage { get; set; }

        public EmailTemplateException(string exceptionMessage)
        {
            ExceptionMessage = exceptionMessage;
        }
    }


}
