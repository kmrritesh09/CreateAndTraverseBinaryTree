using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class BinaryTreeAssignmentTests
{
    private Mock<IBinaryTreeCreateOperations> mockBinaryTreeCreateOperations = new Mock<IBinaryTreeCreateOperations>();
    private Mock<IBinaryTreeTraverseOperations> mockBinaryTreeTraverseOperations = new Mock<IBinaryTreeTraverseOperations>();

    [TestMethod]
    public void Check_ProcessBinaryTreeAssignment_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeAssignment).GetMethod("ProcessBinaryTreeAssignment");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_ProcessBinaryTreeAssignment_WorksCorrectlyWithoutException()
    {
        //Arrange
        Node rootNode = BinaryTreeCreateOperationsTests.CreateExpectedBinaryTree();
        mockBinaryTreeCreateOperations.Setup(x => x.CreateBinaryTree(It.IsAny<ushort[]>())).Returns(rootNode);
        mockBinaryTreeTraverseOperations.Setup(x => x.TraverseBinaryTree(It.IsAny<Node>())).Returns("32, 56, 45, 89, 110, 104, 76");
        BinaryTreeAssignment binaryTreeAssignment = new BinaryTreeAssignment(mockBinaryTreeCreateOperations.Object, mockBinaryTreeTraverseOperations.Object);

        //Act
        using StringWriter sw = new();
        Console.SetOut(sw);
        binaryTreeAssignment!.ProcessBinaryTreeAssignment("89,45,56,76,110,32,104");

        //Assert
        Assert.AreEqual<string>("32, 56, 45, 89, 110, 104, 76", sw.ToString());
    }
}
