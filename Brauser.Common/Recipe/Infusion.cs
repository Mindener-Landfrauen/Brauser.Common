namespace Brauser.Common.Recipe;

public record Infusion
{
    public int Order { get; set; }
    public double RestTemperature { get; set; }
    public DateTimeOffset RestTime { get; set; }
}