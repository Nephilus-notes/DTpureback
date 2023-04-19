namespace DTpureback.Models
{
    public class Character : BaseEntity 
    {
        public string Name { get; set; }

        // Items and Currency
        public int CurrentCurrency { get; set; }

        public int Level { get; set; }

        // Stats
        // I can remove armor from the DB and instead calculate it in browser based on equipment
        public int Armor { get; set; } = 0;
        public int Resistance { get; set; } = 0;
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }


        // Weapon Damage and damage also does not need to be a separate field


        //public int Damage { get; set; }
        //public int WeaponDamage { get; set; } = 0;



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
        public int DefendingFounds { get; set; } = 0;
        public int EvadingRounds { get; set; } = 0;
        public int FleeingRounds { get; set; } = 0;
        // Unused Currently
        public int SlowedRounds { get; set; } = 0;
        public int VulnerableRounds { get; set; } = 0;
        public int StoneArmoredRounds { get; set; } = 0;
        public int DoubledArmedRounds { get; set; } = 0;
        public int BurningBladesRounds { get; set; } = 0;
        public int BurningRounds { get; set; } = 0;
        public int PoisonedRounds { get; set; } = 0;
        public int FocusingRounds { get; set; } = 0;

        public static int Attack(Character self, Character target)
        {
            Random rnd = new Random();
            int attack = rnd.Next(0, 100);

            if (attack == 100)
            {
                int damage = self.DamageValue * 2;
                return damage;
            }
            else if (attack > target.EvadePercentage)
            {
                int totalDamage = self.DamageValue - target.ArmorValue;
                if (totalDamage > 0)
                {
                    return totalDamage;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
