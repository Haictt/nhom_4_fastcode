using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.Common.Exceptions
{
    public class InternalException : Exception
    {
        #region Constructor
        public InternalException()
        {

        }
        public InternalException(string message) : base(message)
        {

        }
        #endregion
    }
}
