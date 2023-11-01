using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Order")]
    public class Order
    {
        

        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Số điện thoại không để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Địa chỉ không để trống")]
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int TyoePayment { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public string CreatedBy { get; internal set; }
        public DateTime ModifiedDate { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
    }
}