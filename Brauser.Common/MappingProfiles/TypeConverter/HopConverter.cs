using AutoMapper;
using Brauser.Common.Import;
using Brauser.Common.Recipe;

namespace Brauser.Common.MappingProfiles.TypeConverter;

public class HopConverter: ITypeConverter<MaischeMalzUndMehrRecipe, List<Hop>>
{
    public List<Hop> Convert(MaischeMalzUndMehrRecipe source, List<Hop> destination, ResolutionContext context)
    {
        throw new NotImplementedException();
    }
}