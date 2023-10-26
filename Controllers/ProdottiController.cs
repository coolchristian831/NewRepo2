using EsercizioWebAPI.Entities;
using EsercizioWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsercizioWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottiController : ControllerBase
    {
        private IProdottoService _service;

        public ProdottiController(IProdottoService service)
        {
            _service = service;
        }
        // GET: api/<ProdottiController>
        [HttpGet]
        public async Task<ActionResult<List<Prodotto>>> GetAllProdotti()
        {
            return null;
        }

        // GET api/<ProdottiController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ProdottiController>
        [HttpPost]
        public async Task<ActionResult> AddProduct(Prodotto p)
        {
            try
            {
                int numeroProdotti = _service.InserisciProdotto(p).Result;
                return Ok($"prodotto inserito/i: {numeroProdotti}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProdottiController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ProdottiController>/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}
