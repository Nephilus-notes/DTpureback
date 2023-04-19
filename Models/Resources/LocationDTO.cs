﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models.Resources
{
    public class LocationDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string EnterText { get; set; }
        public string ExitText { get; set; }
        public List<string>? MoveOptions { get; set; }
        public int? CommonNPC { get; set; }
        public int? UncommonNPC { get; set; }

        public int? RareNPC { get; set; }
        public int? SecretNPC { get; set; }

        public string? Next { get; set; }
    }
}