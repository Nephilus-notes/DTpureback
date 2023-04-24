using DTpureback.Models.Resources;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Linq;

namespace DTpureback.Converters;

public class JsonItemConverter : ValueConverter<Item, string>
{
    public JsonItemConverter() : base(I => JsonConvert.SerializeObject(I),
        jsc => JsonConvert.DeserializeObject<Item>(jsc))
    {

    }
    public static string Jsonify(Item item)
    {
        if (item == null)
        {
            return null;
        }

        return JsonConvert.SerializeObject(item);
    }

    public static Item Itemify(string jsonItem) 
    {
        if (jsonItem == null || jsonItem == string.Empty)
        {
            return null;
        }

        return JsonConvert.DeserializeObject<Item>(jsonItem);
    }

}
