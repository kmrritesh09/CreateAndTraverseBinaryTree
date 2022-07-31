using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class BinaryTreeHelperMethodsTests
{
    [TestMethod]
    public void Check_SortArrayInDescendingOrder_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeHelperMethods).GetMethod("SortArray");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_SortArray_SortsArrayInAscendingOrder()
    {
        //Arrange
        ushort[] inputArray = new ushort[] { 6, 2, 1, 4, 8 };
        ushort[] expectedOutput = new ushort[] { 1, 2, 4, 6, 8 };

        //Act
        var result = BinaryTreeHelperMethods.SortArray(inputArray);

        //Assert
        Assert.IsTrue(result.SequenceEqual(expectedOutput));
    }
}
