using System;
using System.Collections.Generic;

#nullable disable

namespace DailySpellsAPI.DBModel
{
    public partial class Class
    {
        public Class()
        {
            CharacterClasses = new HashSet<CharacterClass>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<CharacterClass> CharacterClasses { get; set; }
    }
}
