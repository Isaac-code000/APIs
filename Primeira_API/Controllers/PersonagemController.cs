using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Primeira_API.Data;
using Primeira_API.Models;

namespace Primeira_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public PersonagemController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> newPersonagem(Personagem personagem)
        {
            _appDbContext.DbPersonagem.Add(personagem);

            await _appDbContext.SaveChangesAsync();
            return Ok(personagem);
        }



    }



}
