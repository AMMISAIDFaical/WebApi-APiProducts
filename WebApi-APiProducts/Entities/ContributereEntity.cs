using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Entities
{
    public class ContributereEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        [MaxLength(50)]
        public string Email { set; get; }
        [Required]
        [MinLength(6)]
        public string Password { set; get; }
        [ForeignKey("OwnerEntityId")]
        public OwnersEntity OwnerEntity { set; get; } 
        public int OwnerEntityId { set; get; }
        

    }
}
