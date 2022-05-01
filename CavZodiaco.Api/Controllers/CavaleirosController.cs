using CavZodiaco.Core.Data;
using CavZodiaco.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CavZodiaco.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CavaleirosController : ControllerBase
    {
        private readonly CavaleirosContext _db;
        public CavaleirosController(CavaleirosContext db)
        {
            _db = db;
        }
        // GET: api/<CavaleirosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Cavaleiros);
        }

        // GET api/<CavaleirosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cavaleiros = _db.Cavaleiros.Find(id);
            if (cavaleiros == null)
                return NotFound();
            return Ok(cavaleiros);
        }

        // POST api/<CavaleirosController>
        [HttpPost]
        public IActionResult Post([FromBody] Cavaleiros cavaleiros)
        {
            if (cavaleiros == null)
                return BadRequest();
            _db.Cavaleiros.Add(cavaleiros);
            _db.SaveChanges();
            return Created($"cavaleiros/{cavaleiros.Id}", cavaleiros);
        }

        // PUT api/<CavaleirosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cavaleiros cavaleiros)
        {
            if(id != cavaleiros.Id)
                return BadRequest();
            _db.Cavaleiros.Update(cavaleiros);
            _db.SaveChanges();
            return NoContent();
        }

        // DELETE api/<CavaleirosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cavaleiro = _db.Cavaleiros.Find(id);
            if (cavaleiro == null)
                return NotFound();
            _db.Cavaleiros.Remove(cavaleiro);
            _db.SaveChanges();
            return NoContent();
        }
    }
}
