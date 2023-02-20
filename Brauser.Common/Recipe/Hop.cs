namespace Brauser.Common.Recipe;

public record Hop
{
    private int Order { get; set; }
    private string Variety { get; set; }
    private double Quantity { get; set; }
    private int Alpha { get; set; }
    private DateTimeOffset CookingTime { get; set; }
}