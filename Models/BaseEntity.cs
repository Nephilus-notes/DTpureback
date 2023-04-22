namespace DTpureback.Models;

public class BaseEntity
{
    public int ID { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
}

