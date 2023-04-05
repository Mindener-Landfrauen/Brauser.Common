namespace Brauser.Common.Recipe;

public record Recipe
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTimeOffset? Date { get; set; }
    public string? Type { get; set; }

    /// <summary>
    /// Ausschlagwürze
    /// </summary>
    public int? BatchSize { get; set; }
    /// <summary>
    /// Sudhausausbeute
    /// </summary>
    public int? BrewhouseYield { get; set; }
    /// <summary>
    /// Stammwürze
    /// </summary>
    public double? OriginalGravity { get; set; }
    /// <summary>
    /// Bittere
    /// </summary>
    public int? Bitterness { get; set; }

    public string? Color { get; set; }
    public double? Alcohol { get; set; }
    public string? ShortDescription { get; set; }

    /// <summary>
    /// Hauptguss
    /// </summary>
    public int? MashWater { get; set; }

    public List<Malt>? Malts { get; set; }

    /// <summary>
    /// EinmaischTemperatur
    /// </summary>
    public double? MashingTemperature { get; set; }
    
    public List<Infusion>? Infusions { get; set; }

    /// <summary>
    /// Abmaischtemperatur
    /// </summary>
    public double? MashoutTemperature { get; set; }

    /// <summary>
    /// Nachguss
    /// </summary>
    public int? SpargeWater { get; set; }

    /// <summary>
    /// Kochzeit Würze
    /// </summary>
    public TimeSpan? WortBoilingTime { get; set; }

    public string? HopVWH_1_Variety { get; set; } // Sorte
    public double? HopVWH_1_Quantity { get; set; } // Menge
    public double? HopVW_1_Alpha { get; set; }

    public List<Hop>? Hops { get; set; }
    
    /// <summary>
    /// Hopfen für Hopfenstopfen/Kalthopfung
    /// </summary>
    public List<DryHop>? DryHops { get; set; }
    public List<AdditionalFermentationIngredient>? AdditionalFermentationIngredients { get; set; }
    public string? Yeast { get; set; }
    
    /// <summary>
    /// Gaertemperatur
    /// </summary>
    public double? FermentationTemperature { get; set; }
    
    /// <summary>
    /// Endvergaerungsgrad
    /// </summary>
    public string? FinalDegreeOfFermentation { get; set; } 
    public string? Carbonation { get; set; }
    public string? AuthorNotes { get; set; }
}
