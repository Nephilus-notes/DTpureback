using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq;

namespace DTpureback.Converters;

public class IntToStringIDConverter : ValueConverter<IEnumerable<int>, string>
{
public IntToStringIDConverter() : base(le => ListToString(le), (s => StringToList(s)))
{

}
public static string ListToString(IEnumerable<int> value)
{
    if (value == null || value.Any() == true)
    {
        return null;
    }

    value = value.Cast<int>().ToList();

        return String.Join(",", value);
}

public static IEnumerable<int> StringToList(string value)
{
    if (value == null || value == string.Empty)
    {
        return null;
    }

    return value.Split(',').Select(i => Convert.ToInt32(i)); ;

}
}