namespace DTpureback.Models.Resources
{
    public class CharacterAbility
    {
        public int ID { get; set; }
        public int CharacterID { get; set; }
        public Character Character { get; set; }
        public int AbilityID { get; set; }
        public Ability Ability { get; set; }
    }
}
