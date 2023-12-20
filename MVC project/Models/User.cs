using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_project.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("id")]
        [Display(Name = "IdUser")]
        public int id { get; set; }

        
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        public List<Card> cards { get; } = new();
    }
}