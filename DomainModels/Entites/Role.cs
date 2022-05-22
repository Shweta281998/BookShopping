using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Entites
{
    public class Role
    {
        public Role()
        {
            createdDate = DateTime.Now;
            Users= new HashSet<User>();

        }
        public int RoleId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Required]
        public string Descrption { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
