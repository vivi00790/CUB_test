using ConsoleApp1;

namespace UnitTest;

using NUnit.Framework;
using FluentAssertions;
using System;

[TestFixture]
public class UnitTest1
{
    [Test]
    public void convert_string_to_decimal_should_success()
    {
        string[] input = ["1.2", "1.4", "0.2", "-", "-0.005"];
        decimal[] expected = [0.462m, 0.396m, 0.066m, 0.0m, -0.00165m];

        var actual = CSharpQ1.ToDecimalThenSortDesc(input);

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void empty_input_should_return_empty_array()
    {
        string[] input = [];

        var actual = CSharpQ1.ToDecimalThenSortDesc(input);

        actual.Should().BeEmpty();
    }

    [Test]
    public void TestSortAmounts_AllNegativeInput()
    {
        string[] input = ["-1.2", "-3.4", "-0.2", "-", "-0.005"];
        decimal[] expected = [0, -0.00165m, -0.066m, -0.396m, -1.122m];

        var actual = CSharpQ1.ToDecimalThenSortDesc(input);

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void TestSortAmounts_InvalidInput()
    {
        string[] input = ["abc", "def", "ghi"];

        var actual = () => CSharpQ1.ToDecimalThenSortDesc(input);
        
        actual.Should().Throw<ConvertStringToDecimalException>()
            .WithMessage("ERR01: Invalid input, not able to convert")
            .WithInnerException<FormatException>();
    }

    [Test]
    public void input_contains_null_should_throw_argument_null_exception()
    {
        string[] input = [null, "1", "2"];

        var actual = () => CSharpQ1.ToDecimalThenSortDesc(input);

        actual.Should().Throw<ConvertStringToDecimalException>()
            .WithMessage("ERR02: Input contains null")
            .WithInnerException<ArgumentNullException>();
    }
}