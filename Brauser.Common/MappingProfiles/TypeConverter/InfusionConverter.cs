using AutoMapper;
using Brauser.Common.Import;
using Brauser.Common.Recipe;

namespace Brauser.Common.MappingProfiles.TypeConverter;

public class InfusionConverter : ITypeConverter<MaischeMalzUndMehrRecipe, List<Infusion>>
{
    public List<Infusion> Convert(MaischeMalzUndMehrRecipe source, List<Infusion> destination, ResolutionContext context)
    {
        throw new NotImplementedException();
    }
}