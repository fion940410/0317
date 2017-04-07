using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        //public void InsertOrder()
        //{
        //        }
        /// <summary>
        /// 新增訂單ACTION
        /// </summary>
        public void InsertOrder(Order order)
        {
        }
        /// <summary>
        /// 刪除訂單By Id
        /// </summary>
        public void DeletOrderById()
        { 
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
        { 
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單Id</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.Custld = "GSS";
            result.CustName = "餓揚資訊";
            return result; }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        { 
            return new List<Order>(); }
    }
}