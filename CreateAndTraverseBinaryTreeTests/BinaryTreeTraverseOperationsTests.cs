using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class BinaryTreeTraverseOperationsTests
{
    [TestMethod]
    public void Check_TraverseBinaryTree_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeTraverseOperations).GetMethod("TraverseBinaryTree");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_PostOrderTraversalOfBinaryTree_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeTraverseOperations).GetMethod("PostOrderTraversalOfBinaryTree");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_PostOrderTraversalOfBinaryTree_TraversesTheTreeCorrectly()
    {
        //Arrange
        Node CreatedBinaryTreeRootNode = BinaryTreeCreateOperationsTests.CreateExpectedBinaryTree();
        string expectedResult = "32, 56, 45, 89, 110, 104, 76, ";

        //Act
        BinaryTreeTraverseOperations binaryTreeTraverseOperations = new BinaryTreeTraverseOperations();
        binaryTreeTraverseOperations.PostOrderTraversalOfBinaryTree(CreatedBinaryTreeRootNode);

        //Assert
        Assert.AreEqual(expectedResult, binaryTreeTraverseOperations.output);
    }

    [TestMethod]
    public void Check_TraverseBinaryTree_OutputsCorrectly()
    {
        //Arrange
        Node CreatedBinaryTreeRootNode = BinaryTreeCreateOperationsTests.CreateExpectedBinaryTree();
        string expectedResult = "32, 56, 45, 89, 110, 104, 76";

        //Act
        BinaryTreeTraverseOperations binaryTreeTraverseOperations = new BinaryTreeTraverseOperations();
        binaryTreeTraverseOperations.TraverseBinaryTree(CreatedBinaryTreeRootNode);

        //Assert
        Assert.AreEqual(expectedResult, binaryTreeTraverseOperations.output);
    }
}