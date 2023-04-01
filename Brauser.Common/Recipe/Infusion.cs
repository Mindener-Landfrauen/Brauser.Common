namespace Brauser.Common.Recipe;

public record Infusion
{
    public int Order { get; set; }
    public double RestTemperature { get; set; }
    public TimeSpan RestTime { get; set; }
}