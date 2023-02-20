namespace Brauser.Common.Recipe;

public record Malt
{
    public int Order { get; set; }
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
}