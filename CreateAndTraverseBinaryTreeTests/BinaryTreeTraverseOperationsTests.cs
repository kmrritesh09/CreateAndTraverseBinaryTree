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
}
