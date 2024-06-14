using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class FizzBuzzServiceTests
{
    private FizzBuzzService _fizzBuzzService;

    [SetUp]
    public void Setup()
    {
        _fizzBuzzService = new FizzBuzzService();
    }

    [Test]
    [TestCase("1", "1", new string[] { "Divided 1 by 3", "Divided 1 by 5" })]
    [TestCase("3", "Fizz", new string[0])]
    [TestCase("5", "Buzz", new string[0])]
    [TestCase("15", "FizzBuzz", new string[0])]
    [TestCase("A", "Invalid item", new string[0])]
    public void ProcessValue_ShouldReturnExpectedResult(string input, string expectedResult, string[] expectedOperations)
    {
        List<string> operations;
        string result = _fizzBuzzService.ProcessValue(input, out operations);

        Assert.Equals(expectedResult, result);
        Assert.Equals(expectedOperations, operations.ToArray());
    }
}
