namespace Brauser.Common.Recipe;

public record Recipe
{
    public string? Name { get; set; }
    public DateTimeOffset? Date { get; set; }
    public string? Type { get; set; }

    public int? BatchSize { get; set; } // Ausschlagwürze
    public int? BrewhouseYield { get; set; } // Sudhausausbeute
    public double? OriginalGravity { get; set; } // Stammwürze
    public int? Bitterness { get; set; } // Bittere

    public string? Color { get; set; }
    public double? Alcohol { get; set; }
    public string? ShortDescription { get; set; }

    public int? MashWater { get; set; } // Hauptguss

    public List<Malt>? Malts { get; set; }

    public double? MashingTemperature { get; set; } // InfusionEinmaischTemperatur

    public List<Infusion>? Infusions { get; set; }

    public double? MashoutTemperature { get; set; } // Abmaischtemperatur

    public int? SpargeWater { get; set; } // Nachguss

    public int? WortBoilingTime { get; set; } // Kochzeitwürze

    public string? HopVWH_1_Variety { get; set; } // Sorte
    public double? HopVWH_1_Quantity { get; set; } // Menge
    public double? HopVW_1_Alpha { get; set; }

    public List<Hop>? Hops { get; set; }
    
    public List<StopfHopfen>? StopfHopfens { get; set; }
    public List<AdditionalFermentationIngredient>? AdditionalFermentationIngredients { get; set; }
    public string? Yeast { get; set; }
    public double? FermentationTemperature { get; set; } // Gaertemperatur
    public string? FinalDegreeOfFermentation { get; set; } // Endvergaerungsgrad
    public string? Carbonation { get; set; }
    public string? AuthorNotes { get; set; }
}