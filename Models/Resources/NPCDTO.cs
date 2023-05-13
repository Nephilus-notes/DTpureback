namespace DTpureback.Models.Resources
{
    public class NPCDTO : Character
    {
        public ICollection<Item>? Items { get; set; }
        public IEnumerable<Ability> Abilities { get; set; }

    }
}
