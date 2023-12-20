using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_project.Models
{
    [Table("Card")]
    public class Card
    {
        [Required]
        [Key]
        [Column("id")]
        [Display(Name = "id")]      
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("Descríption")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int Userid { get; set; }

        //public virtual User Users { get; set; }

        public Card() { }

        
    }
}
