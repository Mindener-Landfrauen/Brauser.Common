using System.Linq.Expressions;
using AutoMapper;
using Brauser.Common.Import;
using Brauser.Common.MappingProfiles.TypeConverter;
using Brauser.Common.Recipe;

namespace Brauser.Common.MappingProfiles;

public class MMMProfile : Profile
{
    public MMMProfile()
    {
        CreateMap<MaischeMalzUndMehrRecipe, Recipe.Recipe>()
            .ForMember(
                dest => dest.Name, 
                opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Datum))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Sorte))
            .ForMember(dest => dest.BatchSize, opt => opt.MapFrom(src => src.Ausschlagswuerze))
            .ForMember(dest => dest.BrewhouseYield, opt => opt.MapFrom(src => src.Sudhausausbeute))
            .ForMember(dest => dest.OriginalGravity, opt => opt.MapFrom(src => src.Stammwuerze))
            .ForMember(dest => dest.Bitterness, opt => opt.MapFrom(src => src.Bittere))
            .ForMember(dest => dest.color, opt => opt.MapFrom(src => src.Farbe))
            
            .ForMember(dest => dest.alcohol, opt => opt.MapFrom(src => src.Alkohol))
            .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.Kurzbeschreibung))
            .ForMember(dest => dest.MashWater, opt => opt.MapFrom(src => src.Infusion_Hauptguss))
            .ForMember(dest => dest.MashingTemperature, opt => opt.MapFrom(src => src.Infusion_Einmaischtemperatur))
            .ForMember(dest => dest.MashoutTemperature, opt => opt.MapFrom(src => src.Abmaischtemperatur))
            .ForMember(dest => dest.SpargeWater, opt => opt.MapFrom(src => src.Nachguss))
            .ForMember(dest => dest.WortBoilingTime, opt => opt.MapFrom(src => src.Kochzeit_Wuerze))
            .ForMember(dest => dest.HopVWH_1_Variety, opt => opt.MapFrom(src => src.Hopfen_VWH_1_Sorte)) // ?
            .ForMember(dest => dest.HopVWH_1_Quantity, opt => opt.MapFrom(src => src.Hopfen_VWH_1_Menge))
            .ForMember(dest => dest.HopVW_1_Alpha, opt => opt.MapFrom(src => src.Hopfen_VWH_1_alpha))
            .ForMember(dest => dest.Yeast, opt => opt.MapFrom(src => src.Hefe))
            .ForMember(dest => dest.FermentationTemperature, opt => opt.MapFrom(src => src.Gaertemperatur))
            .ForMember(dest => dest.FinalDegreeOfFermentation, opt => opt.MapFrom(src => src.Endvergaerungsgrad))
            .ForMember(dest => dest.Carbonation, opt => opt.MapFrom(src => src.Karbonisierung))
            .ForMember(dest => dest.AuthorNotes, opt => opt.MapFrom(src => src.Anmerkung_Autor));

        CreateMap<MaischeMalzUndMehrRecipe, List<Malt>>()
            .ConvertUsing<MaltConverter>();

        CreateMap<MaischeMalzUndMehrRecipe, List<Infusion>>()
            .ConvertUsing<InfusionConverter>();
        
        CreateMap<MaischeMalzUndMehrRecipe, List<Hop>>()
            .ConvertUsing<HopConverter>();
    }

    
}
