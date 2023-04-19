namespace DTpureback.Models;

public class BaseEntity
{
    public int ID { get; set; }
    public int Status { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateUpdated { get; set; }
}

