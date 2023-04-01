namespace Dragon_s_Tail_Portfolio.Models
{
    public class PlayerCharacter : Character 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Items and Currency
        public int LifeTimeCurrency { get; set; }
        public int CurrentCurrency { get; set; }
        public ICollection<Item>? Backpack { get; set; }
        public Equipment? EquippedItems { get; set; }

        // EXP Counters Alpha
        public int StrengthXP { get; set; }
        public int DexterityXP { get; set; }
        public int IntelligenceXP { get; set; }
        public int ConstitutionXP { get; set; }

        // Stats
        public int Armor {  get; set; }
        public int Resistance { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }
        public Item? Weapon { get; set; }
        public int WeaponDamage { get; set; } = 0;
        public int Damage { get; set; }
        // Do I need this? ??
        public List<string>? AttributeList { get; set; }

        // Abilities 
        public List<string>? Abilities { get; set; }

        // Persistent mutable stats
        public int CurrentHP { get; set; }
        public int CurrentMP { get; set; }

        // Temp Stats
        public int ArmorValue { get; set; }
        public int ResistanceValue { get; set;}
        public int EvadePercentage { get; set; }
        public int AttackValue { get; set; }
        public int DamageValue { get; set; }

        // /* Statuses */ 
        // Flags w/ incremntors
        public Boolean Defended { get; set; }
        public Boolean Evading { get; set; }
        public Boolean Fleeing { get; set; }
        // Unused Currently
        public Boolean StoneArmored { get; set; }
        public Boolean Slowed { get; set; }
        public Boolean Vulnerable { get; set; }
        public Boolean DoubleArmed { get; set; }
        public Boolean BurningBlades { get; set; }
        public Boolean StoneFists { get; set; }
        public Boolean Poisoned { get; set; }
        public Boolean Burning {  get; set; }
        public Boolean Focusing { get; set; } // evade ignore based on INT

        // W/O Incrementors 
        public Boolean HitByWind { get; set; }
        public Boolean Stunned { get; set; }

        // Incrementors 
        public int DefendingFounds { get; set; }
        public int EvadingRounds { get; set; }
        public int FleeingRounds { get; set; }
        // Unused Currently
        public int SlowedRounds { get; set; }
        public int VulnerableRounds { get; set; }
        public int StoneArmoredRounds { get; set; }
        public int DoubledArmedRounds { get; set; }
        public int BurningBladesRounds { get; set; }
        public int BurningRounds { get; set; }
        public int PoisonedRounds { get; set; }
        public int FocusingRounds { get; set; }
    }
}
