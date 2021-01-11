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
        Character[] characters = {new Character("Drizzt", "Drow", new CharacterClass[] { new CharacterClass("Barbarian", 3), new CharacterClass("Fighter", 11), new CharacterClass("Ranger", 7) }, new CharacterStatistics(13, 20, 15, 17, 17, 15)),
            new Character("Wulfgar", "Human", new CharacterClass[] { new CharacterClass("Barbarian", 7), new CharacterClass("Fighter", 4) }, new CharacterStatistics(20, 15, 17, 13, 12, 13)),
            new Character("Regis", "Halfing", new CharacterClass[] { new CharacterClass("Rogue", 7) }, new CharacterStatistics(10, 18, 15, 13, 15, 15)),
            new Character("Bruenor", "Dwarf", new CharacterClass[] { new CharacterClass("Fighter", 14) }, new CharacterStatistics(18, 14, 22, 15, 13, 13)) };

        HttpRequestMessage request = new HttpRequestMessage();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Character> GetCharacters()
        {
            return characters;
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return characters[id];
        }
        [HttpGet]
        public ActionResult GetMenu()
        {
            return new OkObjectResult(characters.Select((x, i) => new { index = i, item = x.name }));
        }
       
    }
}
