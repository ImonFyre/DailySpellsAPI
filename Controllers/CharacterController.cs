using DailySpellsAPI.DBModel;
using DailySpellsAPI.Repository;
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
            using (DailySpellsContext dsc = new DailySpellsContext())
            {
                CharacterRepository cr = new CharacterRepository(dsc);
                return cr.GetCharacters();
            }
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            using (DailySpellsContext dsc = new DailySpellsContext())
            {
                CharacterRepository cr = new CharacterRepository(dsc);
                return cr.GetCharacter(id);
            }
        }
        [HttpGet]
        public ActionResult GetMenu()
        {
            using (DailySpellsContext dsc = new DailySpellsContext())
            {
                CharacterRepository cr = new CharacterRepository(dsc);
                return new OkObjectResult(cr.GetCharacters().Select((x, i) => new { index = i, item = x.Name }));
            }
        }
    }
}
