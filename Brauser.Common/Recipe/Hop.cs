namespace Brauser.Common.Recipe;

public record Hop
{
    public int? Order { get; set; }
    public string? Variety { get; set; }
    public double? Quantity { get; set; }
    public int? Alpha { get; set; }
    public DateTimeOffset? CookingTime { get; set; }
}