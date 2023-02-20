using AutoMapper;
using Brauser.Common.Import;
using Brauser.Common.MappingProfiles;
using Brauser.Common.Recipe;
using FluentAssertions;

namespace Brauser.Common.UnitTests;

public class MappingMaischeMalzUndMehr
{
    [Fact]
    public void Map_WhenHopsGiven_ReturnExpectedResult()
    {
        // Arrange
        var now = DateTimeOffset.Now;
        var expected = new Recipe.Recipe
        {
            Name = "name",
            alcohol = "1,1",
            Hops = new List<Hop>
            {
                new Hop
                {
                    Order = 1,
                    Variety = "variety",
                    Quantity = 20.0,
                    Alpha = 3,
                    CookingTime = now
                },
                new Hop
                {
                    Order = 2,
                    Variety = "variety2",
                    Quantity = 20.0,
                    Alpha = 3,
                    CookingTime = now
                }
            }
        };

        var input = new MaischeMalzUndMehrRecipe
        {
            Name = "name",
            Alkohol = 1.1,
            Hopfen_1_alpha = 3,
            Hopfen_1_Sorte = "variety",
            Hopfen_1_Kochzeit = now.ToString(),
            Hopfen_1_Menge = 20,
            Hopfen_2_Sorte = "variety2",
            Hopfen_2_Menge = 20,
            Hopfen_2_alpha = 3,
            Hopfen_2_Kochzeit = now.ToString()
        };

        var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new MMMProfile()));
        var mapper = mapperConfiguration.CreateMapper();

        // Act 
        var result = mapper.Map<Recipe.Recipe>(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}