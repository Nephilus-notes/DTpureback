using AutoMapper;
using DTpureback.Models;
using DTpureback.Models.Resources;
using Microsoft.EntityFrameworkCore;

namespace DTpureback.Data
{
    public class MappingProfile : Profile
    {
        private readonly DragonsTailContext _context;

        public MappingProfile()
        {
            // Empty constructor required by AutoMapper
        }
        public MappingProfile(DragonsTailContext context)
        {


            _context = context;

            CreateMap<PlayerCharacter, PlayerCharacterDTO>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => GetItemsFromDatabaseAsync(src.Items)))
                .ForMember(dest => dest.Abilities, opt => opt.MapFrom(src => GetAbilitiesFromDatabaseAsync(src.Abilities)));

        }

        // Custom resolver method
        private async Task<List<Item>> GetItemsFromDatabaseAsync(IEnumerable<int> itemIDs)
        {
            var itemsFromDatabase = await _context.Items.Where(i => itemIDs.Contains(i.ID)).ToListAsync();

            return itemsFromDatabase;
        }

        private async Task<List<Ability>> GetAbilitiesFromDatabaseAsync(IEnumerable<int> abilityIDs) 
        {
            var abilitiesFromDatabase = await _context.Ability.Where(a => abilityIDs.Contains(a.ID)).ToListAsync();

            return abilitiesFromDatabase;
        }

    }
}
