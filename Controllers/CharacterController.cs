using DailySpellsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DailySpellsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DailySpellsController : ControllerBase
    {
        HttpRequestMessage request = new HttpRequestMessage();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Character> GetCharacters()
        {
            return MockCharacters.characters;
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return MockCharacters.characters[id];
        }
        [HttpGet]
        public ActionResult GetMenu()
        {
            return new OkObjectResult(MockCharacters.characters.Select((x, i) => new { index = i, item = x.Name }));
        }
    }
}
