using AspNetCore.MiniProfiler.Demo.Repository.Model;
using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// MySql 測試資料儲存庫介面
    /// </summary>
    public interface IOrderRepository : IRepositoryGeneric<Order>
    {
    }
}