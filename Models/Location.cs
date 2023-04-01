using System.ComponentModel.DataAnnotations.Schema;

namespace DTpureback.Models
{
    public class Location
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string EnterText { get; set; }
        public string ExitText { get; set; }
        [NotMapped]
        public List<string>? MoveOptions { get; set; }
        [NotMapped]
        public List<string>? NPCOptions { get; set; }
        public string? Next { get; set; }
    }
}
