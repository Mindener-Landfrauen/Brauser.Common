namespace Brauser.Common.Recipe;

public record Hop
{
    public Guid Id { get; set; }
    public int? Order { get; set; }
    public string? Variety { get; set; }
    public double? Quantity { get; set; }
    public double? Alpha { get; set; }
    public TimeSpan? CookingTime { get; set; }
}