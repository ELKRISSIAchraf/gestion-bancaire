using GestionBancaireApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionBancaireApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class MouvementController : ControllerBase
    {

        private readonly AppDbContext _dbContext;

        public MouvementController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("mouvements", Name = "GetAllMouvements")]
        public IEnumerable<Mouvement> Get()
        {
            return _dbContext.Mouvements.Include(m => m.Compte);
        }

        [HttpGet("mouvements/{id}", Name = "GetMouvementById")]
        public Mouvement GetById(int id)
        {
            return _dbContext.Mouvements.Include(m => m.Compte).FirstOrDefault(m => m.Id == id);
        }


        [HttpPost("mouvements", Name = "InsertMouvement")]
        public IActionResult Post(Mouvement mouvement)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Mouvements.Add(mouvement);
                _dbContext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }

            return BadRequest(ModelState);
        }
    }
}
