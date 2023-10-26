using EsercizioWebAPI.Entities;
using EsercizioWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsercizioWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrelliController : ControllerBase
    {
            private ICarrelloService _service;

        public CarrelliController(ICarrelloService service)
        {
            _service = service;
        }
        // GET: api/<CarrelliController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<CarrelliController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrello>> VisualizzaCarrelloAsync(int id)
        {
            CheckId(id);
            try
            {
                return await _service.GetCarrelloAsync(id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CarrelliController>
        [HttpPost]
        public async Task<ActionResult> InserisciCarrelloAsync(Carrello carrello)
        {
            try
            {
                int numeroCarrelli = _service.InsertCarrelloAsync(carrello).Result;
                return Ok($"carrello inserito/i: {numeroCarrelli}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CarrelliController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<CarrelliController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        private void CheckId(int id)
        {
            if (id < 1) throw new ArgumentException("id non valido");
        }
    }
}
