using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models.Resources
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }

        // Items and Currency
        public int CurrentCurrency { get; set; }

        public int Level { get; set; }
        [NotMapped]
        public ICollection<Item>? Items { get; set; }


        // Stats
        // I can remove armor from the DB and instead calculate it in browser based on equipment
        public int Armor { get; set; } = 0;
        public int Resistance { get; set; } = 0;
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }


        [NotMapped]
        public ICollection<Ability> Abilities { get; set; }

        // Persistent mutable stats
        //public int CurrentHP { get; set; }
        //public int CurrentMP { get; set; }

        // Temp Stats
        public int ArmorValue { get; set; }
        //public int ResistanceValue { get; set; }
        public int EvadePercentage { get; set; }
        //public int AttackValue { get; set; }
        public int DamageValue { get; set; }

        // /* Statuses */ 
        // Flags w/ incremntors
        public bool Defended { get; set; } = false;
        public bool Evading { get; set; } = false;
        public bool Fleeing { get; set; } = false;
        // Unused Currently
        public bool StoneArmored { get; set; } = false;
        public bool Slowed { get; set; } = false;
        public bool Vulnerable { get; set; } = false;
        public bool DoubleArmed { get; set; } = false;
        public bool BurningBlades { get; set; } = false;
        public bool StoneFists { get; set; } = false;
        public bool Poisoned { get; set; } = false;
        public bool Burning { get; set; } = false;
        public bool Focusing { get; set; } = false;// evade ignore based on INT

        // W/O Incrementors 
        public bool HitByWind { get; set; } = false;
        public bool Stunned { get; set; } = false;

        // Incrementors 
        public int DefendingRounds { get; set; } = 0;
        public int EvadingRounds { get; set; } = 0;
        public int FleeingRounds { get; set; } = 0;
        // Unused Currently
        public int SlowedRounds { get; set; } = 0;
        public int VulnerableRounds { get; set; } = 0;
        public int StoneArmoredRounds { get; set; } = 0;
        public int DoubleArmedRounds { get; set; } = 0;
        public int BurningBladesRounds { get; set; } = 0;
        public int BurningRounds { get; set; } = 0;
        public int PoisonedRounds { get; set; } = 0;
        public int FocusingRounds { get; set; } = 0;

        public List<CharacterAbility> CharacterAbilities { get; set; }
        public List<CharacterItem> CharacterItems { get; set; }

    }
}

