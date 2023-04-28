using DTpureback.Models.Resources;

namespace DTpureback.Interfaces
{
    public class IEquipment
    {
        public Item? Head { get; set; }
        public Item? Body { get; set; }
        public Item? Hand { get; set; }
    }
}