using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionBancaireApi.Models
{
    public class Mouvement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Montant { get; set; }
        [Required]
        public DateTime DateMnt { get; set; }
        [ForeignKey("CompteId")] // Define the foreign key relationship
        public Compte Compte { get; set; }
    }
}
