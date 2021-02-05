using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySpellsAPI.Model
{
    public class CharacterClass
    {
        public CharacterClass() { }

        public CharacterClass(string className, int classLevel)
        {
            name = className;
            level = classLevel;
        }
        public string name { get; set; }
        public int level { get; set; }
    }
}
