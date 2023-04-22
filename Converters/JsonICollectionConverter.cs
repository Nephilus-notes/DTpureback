using DTpureback.Models.Resources;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System.Linq;

namespace DTpureback.Converters;

public class JsonICollectionConverter : ValueConverter<ICollection<Item>, string>
{
    public JsonICollectionConverter() : base(I => JsonConvert.SerializeObject(I), 
        jsc => JsonConvert.DeserializeObject<ICollection<Item>>(jsc)) 
    {

    }
    public static string JsonifyItemICollection(ICollection<Item> itemList)
    {
        if (itemList == null)
        {
            return null;
        }

        return JsonConvert.SerializeObject(itemList);
    }

    public static ICollection<Item> ItemifyItemICollection(string jsonItem)
    {
        if (jsonItem == null || jsonItem == string.Empty)
        {
            return null;
        }

        return JsonConvert.DeserializeObject<ICollection<Item>>(jsonItem);
    }
}

