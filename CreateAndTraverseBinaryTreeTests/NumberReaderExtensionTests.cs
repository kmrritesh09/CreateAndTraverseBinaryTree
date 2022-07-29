using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class NumberReaderExtensionTests
{
    [TestMethod]
    public void Check_ReadInputNumbersFromConsole_MethodExists()
    {
        //Act
        var method = typeof(NumberReaderExtensions).GetMethod("ReadInputNumbersFromConsole");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_ReadInputNumbersFromConsole_ReturnsAnArrayOfIntegers()
    {
        //Arrange
        string lineOfNumbers = "4,5,7,98,65";
        ushort[] expectedOutput = new ushort[] { 4, 5, 7, 98, 65 };

        //Act
        var result = NumberReaderExtensions.ReadInputNumbersFromConsole(lineOfNumbers);

        //Assert
        Assert.IsTrue(result.SequenceEqual(expectedOutput));
    }

    [TestMethod]
    [DataRow("1,2,-3,5,6")]
    [DataRow("1,2,ch,b,c")]
    [DataRow("1 2 45 67 82")]
    public void Check_ReadInputNumbersFromConsole_ThrowsExceptionWhenInvalidFormat(string lineOfNumbers)
    {
        //Arrange
        Exception? exception = null;

        //Act
        try
        {
            var result = NumberReaderExtensions.ReadInputNumbersFromConsole(lineOfNumbers);
        }
        catch (Exception ex)
        {
            if (ex is FormatException || ex is OverflowException)
            {
                exception = ex;
            }
        }

        //Assert
        Assert.IsNotNull(exception);
    }


}
