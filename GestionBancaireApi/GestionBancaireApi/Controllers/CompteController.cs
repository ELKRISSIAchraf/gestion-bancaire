using GestionBancaireApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Numerics;

namespace GestionBancaireApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class CompteController : ControllerBase
    {

        private readonly AppDbContext _dbContext;

        public CompteController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet("comptes",Name = "GetAllComptes")]
        public IEnumerable<Compte> Get()
        {
             return _dbContext.Comptes.Include(c => c.Mouvements);
        }


        [HttpGet("comptes/compte/{id}", Name = "GetCompteById")]
        public Compte GetById(int id)
        {
              return _dbContext.Comptes.Include(c => c.Mouvements).FirstOrDefault(c => c.Id == id);
        }


        [HttpGet("comptes/{nom}", Name = "GetCompteByName")]
        public Compte GetByName(string nom)
        {
            return _dbContext.Comptes.Include(c => c.Mouvements).FirstOrDefault(c => c.Nom == nom);
        }


        [HttpPost("comptes",Name = "InsertCompte")]
        public IActionResult Post(Compte compte)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Comptes.Add(compte);
                _dbContext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }

            return BadRequest(ModelState);
        }


        [HttpPost("comptes/{id}/credit", Name = "CreditCompte")]
        public IActionResult CreditCompte(int id, [FromBody] decimal montant)
        {
           Compte compte = _dbContext.Comptes.Find(id);
            if (compte == null)
            {
                return NotFound();
             }
            if (montant > 0)
            {
                    compte.Solde = compte.Solde+montant;
                    Mouvement m = new Mouvement();
                    m.Compte = compte;
                    m.Montant = montant;
                    m.DateMnt = DateTime.Now;
                    _dbContext.Mouvements.Add(m);
                    _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(); // Montant invalide, retourne une réponse HTTP 400 Bad Request
            }
        }


        [HttpPost("comptes/{id}/debit", Name = "DebitCompte")]
        public IActionResult DebitCompte(int id, [FromBody] decimal montant)
        {
            Compte compte = _dbContext.Comptes.Find(id);
            if (compte == null)
            {
                return NotFound();
            }
            if (montant > 0 && compte.Solde - montant >= 0)
            {
                compte.Solde = compte.Solde - montant;
                Mouvement m = new Mouvement();
                m.Compte = compte;
                m.Montant = -montant;
                m.DateMnt = DateTime.Now;
                _dbContext.Mouvements.Add(m);
                _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(); // Montant invalide, retourne une réponse HTTP 400 Bad Request
            }
        }

        [HttpPost("comptes/{id}/virement/{recipientId}", Name = "VirementCompte")]
        public IActionResult VirementCompte(int id, int recipientId, [FromBody] decimal montant)
        {
            Compte sender = _dbContext.Comptes.Find(id);
            Compte recipient = _dbContext.Comptes.Find(recipientId);
           
            if (sender != null && recipient != null && montant > 0 && sender.Solde - montant >= 0)
            {
                sender.Solde = sender.Solde - montant;
                recipient.Solde += montant;
                //mouvement sender 
                Mouvement sender_mouvement = new Mouvement();
                sender_mouvement.Compte = sender;
                sender_mouvement.Montant = -montant;
                sender_mouvement.DateMnt = DateTime.Now;
                _dbContext.Mouvements.Add(sender_mouvement);
                //mouvement recipient 
                Mouvement recipient_mouvement = new Mouvement();
                recipient_mouvement.Compte = recipient;
                recipient_mouvement.Montant = montant;
                recipient_mouvement.DateMnt = DateTime.Now;
                _dbContext.Mouvements.Add(recipient_mouvement);
                _dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }


        }


       
    }
}
