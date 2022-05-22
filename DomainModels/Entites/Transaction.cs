﻿using DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Entites
{
   public class Transaction
    {
        public Transaction()
        {
            CreatedDate = DateTime.Now;
        }
        [Key]
        public string TransactionId { get; set; }

        public string PaymentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string Status { get; set; }

        public string PaymentType { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public virtual User User { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
