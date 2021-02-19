using System;
using System.Collections.Generic;

#nullable disable

namespace DailySpellsAPI.DBModel
{
    public partial class Race
    {
        public Race()
        {
            Characters = new HashSet<Character>();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
