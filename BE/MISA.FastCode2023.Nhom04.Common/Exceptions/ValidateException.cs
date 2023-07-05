using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.Common.Exceptions
{
    public class ValidateException : Exception
    {
        #region Constructor
        public ValidateException()
        {

        }
        public ValidateException(string message) : base(message)
        {

        }
        #endregion
    }
}
