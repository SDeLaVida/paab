using System;
using System.IO;
using System.Reflection;
using FluentAssertions;
using Xunit;

namespace paab.Tests;

public class UnitTest1
{
    [Fact]
    public void IsLeapYear_ReturnsTrue_For2016()
    {

        // Arrange
        var sut = new Calendar();

        // Act
        var result = sut.IsLeapYear(2016);

        // Assert
        result.Should().BeTrue();


    }

    [Fact]
    public void IsLeapYear_ThrowsException_ForYearsBefore1582()
    {

        // Arrange
        var sut = new Calendar();

        // Act
        var exo = () => sut.IsLeapYear(1580);
        // Assert
        exo.Should().Throw<InvalidYearException1>();


    }

    [Fact]
    public void IsLeapYear_ReturnsFalse_For2015()
    {

        // Arrange
        var sut = new Calendar();

        // Act
        var result = sut.IsLeapYear(2015);

        // Assert
        result.Should().BeFalse();


    }

    [Fact]
    public void IsUserInputLeapYear_ThrowsTypeConversionError_ForMads()
    {
        var sut = new Calendar();
        using var reader = new StringReader("mads\n");
        Console.SetIn(reader);

        var conversionError = () => sut.IsUserInputLeapYear();

        conversionError.Should().Throw<System.FormatException>();


    }

    [Fact]
    public void IsUserInputLeapYear_ReturnsYay_for2016()
    {
        // Arrange
        var sut = new Calendar();

        using var reader = new StringReader("2016\n");
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        sut.IsUserInputLeapYear();


        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");


    }
}