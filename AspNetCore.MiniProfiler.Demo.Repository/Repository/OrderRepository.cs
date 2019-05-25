﻿using AspNetCore.MiniProfiler.Demo.Repository.Model;
using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// MySql 測試資料儲存庫
    /// </summary>
    public class OrderRepository : RepositoryGeneric<Order>, IOrderRepository
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="factory">連線工廠</param>
        public OrderRepository(IMySqlConnectionFactory factory) : base(factory)
        {
        }
    }
}