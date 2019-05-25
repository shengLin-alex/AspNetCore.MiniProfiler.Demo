using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCore.MiniProfiler.Demo.Repository.Model
{
    /// <summary>
    /// MySql 測試實體資料
    /// </summary>
    [Table("order")]
    public class Order
    {
        /// <summary>
        /// 編號
        /// </summary>
        [Key]
        [Column("order_id")]
        public int Id { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        [Column("order_userid")]
        public int UserId { get; set; }
    }
}