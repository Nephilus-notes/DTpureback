namespace DTpureback.Models.Resources
{
    public class AbilityDTO: Ability
    {
        public IEnumerable<Ability> Descendants { get; set; }


    }
}
