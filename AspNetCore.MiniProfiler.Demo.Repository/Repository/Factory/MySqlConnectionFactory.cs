using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// MySql 連線工廠
    /// </summary>
    public class MySqlConnectionFactory : MySqlDbConnectionFactoryBase
    {
        /// <summary>
        /// 連線字串鍵值
        /// </summary>
        protected override string ConnectionKey { get; set; } = "MySqlLocal";
    }
}