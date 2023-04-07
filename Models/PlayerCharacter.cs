using DTpureback.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models
{
    public class PlayerCharacter : Character
    {
        // Items and Currency
        public int LifeTimeCurrency { get; set; }
        public ICollection<Item>? Backpack { get; set; }
        [NotMapped]
        public IEquipment? EquippedItems { get; set; }
        public Item? Weapon { get; set; }

        // EXP Counters Alpha
        public int StrengthXP { get; set; } = 0;
        public int DexterityXP { get; set; } = 0;
        public int IntelligenceXP { get; set; } = 0;
        public int ConstitutionXP { get; set; } = 0;

        public int CurrentHP { get; set; }
        public int CurrentMP { get; set; }



        // Do I need this? ??
        //public List<string>? AttributeList { get; set; }

        // Abilities 
        //public List<string>? Abilities { get; set; }




    }
}
