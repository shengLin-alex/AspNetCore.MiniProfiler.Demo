using Power.Repository.Dapper;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// PostgreSql 連線工廠
    /// </summary>
    public class PostgreSqlConnectionFactory : PostgreSqlConnectionFactoryBase
    {
        /// <summary>
        /// 連線字串鍵值
        /// </summary>
        protected override string ConnectionKey { get; set; } = "PostgreSqlLocal";
    }
}