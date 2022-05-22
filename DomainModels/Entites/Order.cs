using DomainModels.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Entities
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItems>();
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int OrderId { get; set; }
        public decimal Total { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Customer { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [Required]
        public string ContactNo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string ShippingAddress { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Status { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<OrderItems> Items { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual User User { get; set; }
    }
}
