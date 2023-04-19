using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTpureback.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            SaveFiles = new HashSet<SaveFile>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<SaveFile>? SaveFiles { get; set; }
    }
}
