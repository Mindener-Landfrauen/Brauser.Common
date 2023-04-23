namespace Brauser.Common.Ingredient;

public class Ingredient
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Category Category { get; set; }
    public string? Notes { get; set; }
}