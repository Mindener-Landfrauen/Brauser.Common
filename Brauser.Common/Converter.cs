using Brauser.Common.Import;
using Brauser.Common.Recipe;

namespace Brauser.Common;

/// <summary>
/// A naive converter from one recipe format to another.
/// </summary>
public static class Converter
{
    /// <summary>
    /// Get a <see cref="Recipe"/> from a <see cref="MaischeMalzUndMehrRecipe"/>.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static Recipe.Recipe GetRecipeFromMmm(MaischeMalzUndMehrRecipe input)
    {
        input.Datum ??= DateTimeOffset.Now.ToString();

        var recipe = new Recipe.Recipe
            {
                Name = input.Name,
                Alcohol = input.Alkohol,
                Color = input.Farbe,
                Bitterness = input.Bittere,
                Carbonation = input.Karbonisierung,
                Date = DateTimeOffset.Parse(input.Datum),
                Type = input.Sorte,
                Yeast = input.Hefe,
                AuthorNotes = input.Anmerkung_Autor,
                BatchSize = input.Ausschlagswuerze,
                MashWater = input.Infusion_Hauptguss,
                FermentationTemperature = double.Parse(input.Gaertemperatur!),
                BrewhouseYield = input.Sudhausausbeute,
                MashingTemperature = input.Infusion_Einmaischtemperatur!,
                MashoutTemperature = double.Parse(input.Abmaischtemperatur!),
                OriginalGravity = input.Stammwuerze,
                ShortDescription = input.Kurzbeschreibung,
                SpargeWater = input.Nachguss,
                WortBoilingTime = input.Kochzeit_Wuerze,
                HopVW_1_Alpha = input.Hopfen_VWH_1_alpha,
                HopVWH_1_Quantity = input.Hopfen_VWH_1_Menge,
                HopVWH_1_Variety = input.Hopfen_VWH_1_Sorte,
                FinalDegreeOfFermentation = input.Endvergaerungsgrad,
                Malts = GetMalts(input),
                Infusions = GetInfusions(input),
                Hops = new List<Hop>(),
            };

            return recipe;
        
    }

    private static List<Hop> GetHops(MaischeMalzUndMehrRecipe recipe)
    {
        var hops = new List<Hop>();

        if (recipe.Hopfen_1_Sorte is not null)
        {
            hops.Add(new Hop
            {
                Order = 1,
                Quantity = recipe.Hopfen_1_Menge,
                Alpha = recipe.Hopfen_1_alpha,
                Variety = recipe.Hopfen_1_Sorte,
                CookingTime = DateTimeOffset.Parse(recipe.Hopfen_1_Kochzeit!)
            });
        }
        
        if (recipe.Hopfen_2_Sorte is not null)
        {
            hops.Add(new Hop
            {
                Order = 2,
                Quantity = recipe.Hopfen_2_Menge,
                Alpha = recipe.Hopfen_2_alpha,
                Variety = recipe.Hopfen_2_Sorte,
                CookingTime = DateTimeOffset.Parse(recipe.Hopfen_2_Kochzeit!)
            });
        }
        
        return hops;
    }

    /// <summary>
    /// Extract the malts from the recipe and provide a list of them.
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    private static List<Malt> GetMalts(MaischeMalzUndMehrRecipe recipe)
    {
        var malts = new List<Malt>();
        
        if (recipe.Malz1 is not null)
        {
            malts.Add(new Malt
            {
                Order = 1,
                Name = recipe.Malz1,
                Quantity = recipe.Malz1_Menge,
                Unit = recipe.Malz1_Einheit,
                
            });
        }

        if (recipe.Malz2 is not null)
        {
            malts.Add(new Malt
            {
                Order = 2,
                Name = recipe.Malz2,
                Quantity = recipe.Malz2_Menge,
                Unit = recipe.Malz2_Einheit
            });
        }

        if (recipe.Malz3 is not null)
        {
            malts.Add(new Malt
            {
                Order = 3,
                Name = recipe.Malz3,
                Quantity = recipe.Malz3_Menge,
                Unit = recipe.Malz3_Einheit
            });
        }

        return malts;
    }

    private static List<Infusion> GetInfusions(MaischeMalzUndMehrRecipe recipe)
    {
        var infusions = new List<Infusion>();

        if (recipe.Infusion_Rastzeit1 is not null)
        {
            infusions.Add(new Infusion
            {
                Order = 1,
                RestTemperature = double.Parse(recipe.Infusion_Rasttemperatur1!),
                RestTime = DateTimeOffset.Parse(recipe.Infusion_Rastzeit1)
            });
        }
        
        if (recipe.Infusion_Rastzeit2 is not null)
        {
            infusions.Add(new Infusion
            {
                Order = 2,
                RestTemperature = double.Parse(recipe.Infusion_Rasttemperatur2!),
                RestTime = DateTimeOffset.Parse(recipe.Infusion_Rastzeit2)
            });
        }
        
        if (recipe.Infusion_Rastzeit3 is not null)
        {
            infusions.Add(new Infusion
            {
                Order = 3,
                RestTemperature = double.Parse(recipe.Infusion_Rasttemperatur3!),
                RestTime = DateTimeOffset.Parse(recipe.Infusion_Rastzeit3)
            });
        }
        
        return infusions;
    }
}