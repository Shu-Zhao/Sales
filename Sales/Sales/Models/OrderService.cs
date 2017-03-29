using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder(Models.Order order)
        {
            
        }

        /// <summary>
        /// 刪除訂單By Id
        /// </summary>
        public void DeleteOrderById(string orderId)
        {
            
        }

        /// <summary>
        /// 修改訂單
        /// </summary>
        public void UpdateOrder(Models.Order order)
        {
            
        }

        /// <summary>
        /// 查詢訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            return new Order(); 
        }

        /// <summary>
        /// 查詢訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
        

    }
}