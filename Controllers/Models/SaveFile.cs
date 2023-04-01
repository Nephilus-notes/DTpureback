namespace Dragon_s_Tail_Portfolio.Models
{
    public class SaveFile
    {
        public int ID { get; set; }

        // Foreign Keys
        public int UserID { get; set; }
        public int CharacterID { get; set; }
        public string LocationID { get; set; }
    }
}
