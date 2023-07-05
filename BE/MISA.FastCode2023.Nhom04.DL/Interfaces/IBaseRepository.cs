using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.DL.Interfaces
{
    public interface IBaseRepository<TEntity, TEntityFilter>
    {
        /// <summary>
        /// Hàm mở kết nối tới db
        /// </summary>
        /// <returns>DbConnection</returns>
        /// AUTHOR: DPHai 
        Task<DbConnection> GetOpenConnectionAsync();
    }
}
