using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Department { set; get; }

        [Required]
        [MaxLength(50)]
        public string Skype { set; get; }

        [Required]
        [MaxLength(50)]
        public string Mobile { set; get; }

        [Required]
        [MaxLength(50)]
        public string Email { set; get; }

        [Required]
        [MaxLength(50)]
        public string Facebook { set; get; }

        [MaxLength(50)]
        public bool Status { set; get; }

        public int? DisplayOrder { set; get; }
    }
}