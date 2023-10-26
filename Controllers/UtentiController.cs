using EsercizioWebAPI.DTO;
using EsercizioWebAPI.Entities;
using EsercizioWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsercizioWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtentiController : ControllerBase
    {

        private IUtenteService _service;

        public UtentiController(IUtenteService service)
        {
            _service = service;
        }
        // GET: api/<UtentiController>
        [HttpGet]
        public async Task<ActionResult<List<Utente>>> RestituisciTuttiUtenti()
        {
            return await _service.GetAllUtenti();
        }

        // GET api/<UtentiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Utente>> Get(int id)
        {
            CheckId(id);
            try { 
            return await _service.GetUtente(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UtentiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UtentiController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PasswordUtenteDTO pass)
        {
            try { 
            await _service.ModifyPasswordUtente(id, pass);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private void CheckId(int id)
        {
            if (id < 1) throw new ArgumentException("id non valido");
        }

        // DELETE api/<UtentiController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
