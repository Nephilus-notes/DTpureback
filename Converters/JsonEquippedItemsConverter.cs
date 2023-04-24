using DTpureback.Interfaces;
using DTpureback.Models.Resources;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Linq;
namespace DTpureback.Converters;

public class JsonEquippedItemsConverter : ValueConverter<IEquipment, string>
{
    public JsonEquippedItemsConverter() : base(e => JsonConvert.SerializeObject(e),
        jsc => JsonConvert.DeserializeObject<IEquipment>(jsc))
    {

    }
}

