using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entites
{
    [Table("Users")]
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
            Roles = new HashSet<Role>();
        }
        [Key]
        public int UserId { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string Address { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [Required]
        public string contactNo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
