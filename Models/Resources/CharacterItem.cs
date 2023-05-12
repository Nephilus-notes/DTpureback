namespace DTpureback.Models.Resources
{
    public class CharacterItem
    {
        public int ID { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}
