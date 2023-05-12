namespace DTpureback.Models.Resources
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int ItemStat { get; set; }
        public int Price { get; set; }
        public string Slot { get; set; }
        public string Description { get; set; }

        public List<CharacterItem> CharacterItems { get; set; }


        //public ICollection<PlayerCharacter> Character { get; set; }
    }
}
