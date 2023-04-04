using DTpureback.Models;

namespace DTpureback.Interfaces
{
    public interface IEquipment
    {
        public Item Head { get; set; }
        public Item Body { get; set; }
        public Item Hand { get; set; }
    }
}