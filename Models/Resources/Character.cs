using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models.Resources
{
    public class Character : BaseEntity
    {
        /**
         * Name, CurrentCurrency, Level, Items, Armor, Resistane, Streangth, Dexterity, Constitution, Intelligence
         * Abilities
         * 
         */
        public string Name { get; set; }

        // Items and Currency
        public int CurrentCurrency { get; set; }

        public int Level { get; set; }
        public IEnumerable<int>? Items { get; set; }


        // Stats
        // I can remove armor from the DB and instead calculate it in browser based on equipment
        public int Armor { get; set; } = 0;
        public int Resistance { get; set; } = 0;
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }

        public IEnumerable<int> Abilities { get; set; } = new List<int> { 1};


        //public List<CharacterAbility> CharacterAbilities { get; set; }
        //public List<CharacterItem> CharacterItems { get; set; }

    }
}

