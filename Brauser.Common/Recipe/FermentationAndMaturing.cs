namespace Brauser.Common.Recipe;

public class FermentationAndMaturing
{
    /// <summary>
    ///     Hopfen für Hopfenstopfen/Kalthopfung
    /// </summary>
    public List<DryHop>? DryHops { get; set; }

    public List<AdditionalFermentationIngredient>? AdditionalFermentationIngredients { get; set; }
    public string? Yeast { get; set; }

    /// <summary>
    ///     Endvergaerungsgrad given in %
    /// </summary>
    public int? FinalDegreeOfFermentation { get; set; }

    /// <summary>
    ///     Gaertemperatur min
    /// </summary>
    public double? FermentationTemperatureMin { get; set; }

    /// <summary>
    ///     Gaertemperatur min
    /// </summary>
    public double? FermentationTemperatureMax { get; set; }

    /// <summary>
    /// Carbonation in g/l
    /// </summary>
    public double? Carbonation { get; set; }
}
