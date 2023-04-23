namespace Brauser.Common.Recipe;

public record Recipe
{
    public Recipe()
    {
        GeneralInformation = new GeneralInformation();
        BrewingProcess = new BrewingProcess();
        FermentationAndMaturing = new FermentationAndMaturing();
    }
    
    public Guid Id { get; set; }

    public GeneralInformation GeneralInformation { get; set; }

    public BrewingProcess BrewingProcess { get; set; }

    public FermentationAndMaturing FermentationAndMaturing { get; set; }
}