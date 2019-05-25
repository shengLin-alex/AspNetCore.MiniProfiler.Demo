using AspNetCore.MiniProfiler.Demo.Repository.Model;
using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// PostgreSql 測試資料儲存庫
    /// </summary>
    public class UserRepository : RepositoryGeneric<User>, IUserRepository
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="factory">連線工廠</param>
        public UserRepository(IPostgreSqlConnectionFactory factory) : base(factory)
        {
        }
    }
}