using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GestionBancaireApi.Models
{
    public class Compte
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [Required]
        public decimal Solde { get; set; }

        [InverseProperty("Compte")]
        [JsonIgnore]
        public ICollection<Mouvement> Mouvements { get; set; }
    }
}
