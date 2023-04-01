namespace Dragon_s_Tail_Portfolio.Models
{
    public class Location
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string EnterText { get; set; }
        public string ExitText { get; set; }
        public List<string>MoveOptions { get; set; }
        public List<string> NPCOptions { get; set; }
        public string Next { get; set; }
    }
}
