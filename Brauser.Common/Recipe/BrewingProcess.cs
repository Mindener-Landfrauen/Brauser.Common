namespace Brauser.Common.Recipe;

public class BrewingProcess
{
    /// <summary>
    ///     Hauptguss
    /// </summary>
    public int? MashWater { get; set; }

    public List<Malt>? Malts { get; set; }

    /// <summary>
    ///     EinmaischTemperatur
    /// </summary>
    public double? MashingTemperature { get; set; }

    public List<Infusion>? Infusions { get; set; }

    /// <summary>
    ///     Abmaischtemperatur
    /// </summary>
    public double? MashoutTemperature { get; set; }

    /// <summary>
    ///     Nachguss
    /// </summary>
    public int? SpargeWater { get; set; }

    /// <summary>
    ///     Kochzeit Würze
    /// </summary>
    public TimeSpan? WortBoilingTime { get; set; }

    /// <summary>
    ///     Hop VorderWuerzeHopfung
    /// </summary>
    /// TODO: Choose a nicer name for VWH
    public Hop? HopVWH { get; set; }

    public List<Hop>? Hops { get; set; }
}