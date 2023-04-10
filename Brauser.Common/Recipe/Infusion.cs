namespace Brauser.Common.Recipe;

public record Infusion
{
    public Guid Id { get; set; }
    public int Order { get; set; }
    public double RestTemperature { get; set; }
    public TimeSpan RestTime { get; set; }
}