using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string input = "";

        //Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { };

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "Hello";

        //Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "Hello"};

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = "Hello,how,are,you";

        //Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "Hello", "how", "are", "you" };

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string input = "Hello,how    ,are   ,you     ";

        //Act
        string[] result = CsvParser.ParseCsv(input);
        string[] expected = { "Hello", "how", "are", "you" };

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
