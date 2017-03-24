using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class Order
    {
        ///<summary>
        /// 訂單編號
        /// </summary>
        public int OrderDd { get; set; }

        ///客戶代號
        public string Custld { get; set; }

        ///客戶名稱
        public string CustName { get; set; }


        ///
        ///業務(員工)代號
        ///
        public int EmpId { get; set; }

        ///
        ///業務(員工姓名)
        ///
        public string EmpName { get; set; }

        ///訂單日期
        public DateTime? orderDate { get; set; }

        ///
        ///需要日期
        ///
        public DateTime? RequireDdate { get; set; }
    }
}