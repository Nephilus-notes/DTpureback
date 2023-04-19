namespace DTpureback.Models
{
    public class SaveFile : BaseEntity
    {

        // Foreign Keys
        public int UserID { get; set; }
        public int PlayerCharacterID { get; set; }
        public string LocationID { get; set; }
        public virtual User User { get; set; }
        public virtual PlayerCharacter Character { get; set; }
        public virtual Location Location { get; set; }
    }
}
