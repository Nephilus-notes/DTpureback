﻿namespace DTpureback.Models.Resources
{
    public class Ability
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Description { get; set; }
        public string AffectedAttribute { get; set; }
        public int Duration { get; set; } = 0;
        public string Type { get; set; } = "physical";
        public int Cost { get; set; } = 0;
        public int Modifier { get; set; } = 0;

        public List<CharacterAbility> CharacterAbilities { get; set; }
    }
}
