using Xunit;
using PassValidator.Core;

namespace PassValidator.Core.Tests;

public class PassValidatorServiceTests
{
    [Fact]
    public void Validate_WhenPassIsLessThan8Characters_ShouldReturnFalse()
    {
        // Arrange
        var service = new PassValidatorService();
        
        // Act
        var result = service.Validate("Short1!");
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPasswordHasNoNumbers_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate("NoNumbersOnlyLetters!");
        Assert.False(result);
    }
}