using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Entities
{
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [MaxLength(50)]
        public string ProdName { set; get; }
        public string LinkDoc { set; get; }
        public string LinkApi { set; get; }
        [Required]
        public string Status { set; get; }
        [ForeignKey("ContributerId")]
        [Required]
        public ContributereEntity ContributerEntity { set; get; }
        public int ContributerId { set; get; }

    }
}
