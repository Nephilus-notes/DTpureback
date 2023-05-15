using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models.Resources
{
    public class LocationDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string EnterText { get; set; }
        public string? MiddleText { get; set; }

        public string ExitText { get; set; }
        public List<Location>? MoveOptions { get; set; }
        public int? CommonNPC { get; set; }
        public int? UncommonNPC { get; set; }

        public int? RareNPC { get; set; }
        public int? SecretNPC { get; set; }

        public string? Next { get; set; }
        public string? OtherText { get; set; }
        public IEnumerable<int> OtherList { get; set; }
    }
}
