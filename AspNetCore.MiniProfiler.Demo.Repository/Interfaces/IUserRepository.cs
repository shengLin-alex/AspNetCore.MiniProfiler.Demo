using AspNetCore.MiniProfiler.Demo.Repository.Model;
using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// Postgre 測試資料儲存庫介面
    /// </summary>
    public interface IUserRepository : IRepositoryGeneric<User>
    {
    }
}