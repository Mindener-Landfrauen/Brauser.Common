namespace Brauser.Common.Recipe;

/// <summary>
/// While importing from MaischeMalzUndMehr.de it may be required to fill StartTime and Duration
/// </summary>
public class DryHop
{
    public Guid Id { get; set; }
    public int? Order { get; set; }
    public string? Variety { get; set; }
    public string? Quantity { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan Duration { get; set; }
}