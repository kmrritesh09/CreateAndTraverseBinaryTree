using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void Check_Node_Constructor_Creates_Desired_Node()
    {
        //Arrange
        int value = It.IsAny<ushort>();

        //Act
        Node node = new Node(value);

        //Assert
        Assert.AreEqual(value, node.Value);
        Assert.IsNull(node.LeftNode);
        Assert.IsNull(node.RightNode);
    }
}
