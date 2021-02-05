namespace DailySpellsAPI.Model
{
	public class CharacterStatistics
    {
        public CharacterStatistics() { }

        public CharacterStatistics(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Str = strength;
            Dex = dexterity;
            Con = constitution;
            Int = intelligence;
            Wis = wisdom;
            Cha = charisma;
        }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }
}
