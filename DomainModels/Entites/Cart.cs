﻿using DomainModels.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Entities
{
    public class Cart
    {
        public Cart()
        {
            Items = new HashSet<CartItems>();
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int CartId { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CartItems> Items { get; set; }
        public virtual User User { get; set; }
    }
}
