using System;
using System.Collections.Generic;

#nullable disable

namespace DailySpellsAPI.DBModel
{
    public partial class CharacterStat
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        public virtual Character Character { get; set; }
    }
}
