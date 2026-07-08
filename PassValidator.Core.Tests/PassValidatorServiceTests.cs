using Xunit;
using PassValidator.Core;

namespace PassValidator.Core.Tests;

public class PassValidatorServiceTests
{
    [Fact]
    public void Validate_WhenPassIsNull_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate(null!);
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPassIsEmpty_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate("");
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPassIsLessThan8Characters_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate("Short1!");
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPasswordHasNoSpecialCharacters_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate("NoSpecialChars123");
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPasswordHasNoNumbers_ShouldReturnFalse()
    {
        var service = new PassValidatorService();
        var result = service.Validate("NoNumbersOnlyLetters!");
        Assert.False(result);
    }

    [Fact]
    public void Validate_WhenPasswordIsValid_ShouldReturnTrue()
    {
        var service = new PassValidatorService();
        var result = service.Validate("ValidPass123!");
        Assert.True(result);
    }
}