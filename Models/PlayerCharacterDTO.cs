﻿using DTpureback.Interfaces;
using DTpureback.Models.Resources;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models
{
    public class PlayerCharacterDTO : Character
    {
        // Items and Currency
        public int LifeTimeCurrency { get; set; }
        public ICollection<Item>? Items { get; set; }
        [NotMapped]
        public IEquipment EquippedItems { get; set; }
        public IEnumerable<Ability> Abilities { get; set; }

        // EXP Counters Alpha
        public int StrengthXP { get; set; } = 0;
        public int DexterityXP { get; set; } = 0;
        public int IntelligenceXP { get; set; } = 0;
        public int ConstitutionXP { get; set; } = 0;

        // Max hp and mp can also be removed if I add logic to calculate it in browser
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }

        public int CurrentHP { get; set; }
        public int CurrentMP { get; set; }

        public string? CurrentLocation { get; set; } = "T";

        public int KratabsFollyExplored { get; set; } = 0;

        public int DrippingDeathExplored { get; set; } = 0;
        public int PlayersRespiteExplored { get; set; } = 0;
        public int TailOfTheDragonExplored { get; set; } = 0;
        public int ThagragsHopeExplored { get; set; } = 0;

        public int WebOfDepthsExplored { get; set; } = 0;
        public int GraithsGrottoExplored { get; set; } = 0;
        public int GraithQueensLairExplored { get; set; } = 0;

        // Abilities 
        //public List<string>? Abilities { get; set; }



    }
}
