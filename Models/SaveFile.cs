namespace DTpureback.Models
{
    public class SaveFile
    {
        public int ID { get; set; }

        // Foreign Keys
        public int UserID { get; set; }
        public int PlayerCharacterID { get; set; }
        public string LocationID { get; set; }
    }
}
