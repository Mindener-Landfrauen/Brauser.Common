namespace Brauser.Common.Recipe;

public class GeneralInformation
{
    public string? Name { get; set; }
    public DateTimeOffset? Date { get; set; }
    public string? Type { get; set; }

    /// <summary>
    ///     Ausschlagwürze
    /// </summary>
    public int? BatchSize { get; set; }

    /// <summary>
    ///     Sudhausausbeute
    /// </summary>
    public int? BrewhouseYield { get; set; }

    /// <summary>
    ///     Stammwürze
    /// </summary>
    public double? OriginalGravity { get; set; }

    /// <summary>
    ///     Bittere
    /// </summary>
    public int? Bitterness { get; set; }

    public string? Color { get; set; }
    public double? Alcohol { get; set; }
    public string? ShortDescription { get; set; }
    public string? AuthorNotes { get; set; }
}