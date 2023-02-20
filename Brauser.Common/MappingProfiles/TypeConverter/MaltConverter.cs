using System.Reflection;
using System.Xml.Serialization;
using AutoMapper;
using Brauser.Common.Import;
using Brauser.Common.Recipe;

namespace Brauser.Common.MappingProfiles.TypeConverter;

public class MaltConverter : ITypeConverter<MaischeMalzUndMehrRecipe, List<Malt>>
{
    public List<Malt> Convert(MaischeMalzUndMehrRecipe source, List<Malt> destination, ResolutionContext context)
    {
        var result = new List<Malt>();

        if (source.Malz1 is not null)
        {
            result.Add(new Malt
            {
                Order = 1,
                Name = source.Malz1,
                Quantity = source.Malz1_Menge,
                Unit = source.Malz1_Einheit
            });
        }

        return result;
    }
}
