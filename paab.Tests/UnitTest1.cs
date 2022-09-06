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
        result.Should().BeFalse();


    }
    [Fact]
    public void IsUserInputLeapYear_ReturnsYay_for2016()
    {
        // Arrange
        var sut = new Calendar();

        using var reader = new StringReader("2015\n");
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        sut.IsUserInputLeapYear();


        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");


    }
}