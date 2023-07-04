using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.Common.Entity
{
    public abstract class Base
    {
        #region Properties
        /// <summary>
        /// Ngày tạo
        /// </summary>
        /// AUTHOR: DPHai(20/5/2023)
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người tạo
        /// </summary>
        /// AUTHOR: DPHai(20/5/2023)
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Ngày sửa
        /// </summary>
        /// AUTHOR: DPHai(20/5/2023)
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người sửa
        /// </summary>
        /// AUTHOR: DPHai(20/5/2023)
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
