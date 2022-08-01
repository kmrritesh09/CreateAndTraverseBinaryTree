using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreateAndTraverseBinaryTreeTests;

[TestClass]
public class BinaryTreeCreateOperationsTests
{
    [TestMethod]
    public void Check_CreateBinaryTree_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeCreateOperations).GetMethod("CreateBinaryTree");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_CreateBST_MethodExists()
    {
        //Act
        var method = typeof(BinaryTreeCreateOperations).GetMethod("CreateBST");

        //Assert
        Assert.IsNotNull(method);
    }

    [TestMethod]
    public void Check_CreateBST_CreatesABSTCorrectly()
    {
        //Arrange
        ushort[] arr = { 32, 45, 56, 76, 89, 104, 110 };
        Node expectedTreeRootNode = CreateExpectedBinaryTree();

        //Act
        BinaryTreeCreateOperations binaryTreeCreateOperations = new BinaryTreeCreateOperations();
        Node outputTreeRootNode = binaryTreeCreateOperations.CreateBST(arr, 0, arr.Length - 1, null!);

        //Assert
        Assert.IsTrue(CheckIfTreesAreSame(expectedTreeRootNode, outputTreeRootNode));
    }

    [TestMethod]
    public void Check_CreateBinaryTree_CreateABSTWithUnshortedArray()
    {
        //Arrange
        ushort[] arr = { 56, 76, 32, 104, 110, 45, 89 };
        Node expectedTreeRootNode = CreateExpectedBinaryTree();

        //Act
        BinaryTreeCreateOperations binaryTreeCreateOperations = new BinaryTreeCreateOperations();
        Node outputTreeRootNode = binaryTreeCreateOperations.CreateBinaryTree(arr);

        //Assert
        Assert.IsTrue(CheckIfTreesAreSame(expectedTreeRootNode, outputTreeRootNode));
    }



    public static Node CreateExpectedBinaryTree()
    {
        Node expectedRootNode = new Node(76);
        expectedRootNode.LeftNode = new Node(45);
        expectedRootNode.RightNode = new Node(104);
        expectedRootNode.LeftNode.LeftNode = new Node(32);
        expectedRootNode.LeftNode.RightNode = new Node(56);
        expectedRootNode.RightNode.LeftNode = new Node(89);
        expectedRootNode.RightNode.RightNode = new Node(110);

        return expectedRootNode;
    }

    private bool CheckIfTreesAreSame(Node expectedTreeRootNode, Node outputTreeRootNode)
    {
        if (expectedTreeRootNode == null && outputTreeRootNode == null)
            return true;

        else if (expectedTreeRootNode != null &&
             outputTreeRootNode == null)
            return false;
        else if (expectedTreeRootNode == null &&
                 outputTreeRootNode != null)
            return false;
        else
        {
            // Check if current data of both trees equal
            // and recursively check for left and right subtrees
            if (expectedTreeRootNode!.Value == outputTreeRootNode!.Value &&
                CheckIfTreesAreSame(expectedTreeRootNode.LeftNode!, outputTreeRootNode.LeftNode!) == true &&
                CheckIfTreesAreSame(expectedTreeRootNode.RightNode!, outputTreeRootNode.RightNode!) == true)
                return true;
            else
                return false;
        }
    }
}
