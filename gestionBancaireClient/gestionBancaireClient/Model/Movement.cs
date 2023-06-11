using System;

namespace gestionBancaireClient.Model
{
    public class Movement
    {
        public int Id { get; set; }
        public float Montant { get; set; }
        public DateTime DateMnt { get; set; }
        public Compte compte { get; set; }
    }
}
