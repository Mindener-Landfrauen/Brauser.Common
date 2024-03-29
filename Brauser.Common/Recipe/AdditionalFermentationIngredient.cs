namespace Brauser.Common.Recipe;

public class AdditionalFermentationIngredient
{
    public Guid Id { get; set; }
    public int? Order { get; set; }
    public string? Name { get; set; }
    public int? Quantity { get; set; }
    public string? Unit { get; set; }
}