﻿namespace CreateAndTraverseBinaryTree;

public class BinaryTreeTraverseOperations : IBinaryTreeTraverseOperations
{
    string output = null!;
    public void TraverseBinaryTree(Node rootNode)
    {
        output = string.Empty;

        PostOrderTraversalOfBinaryTree(rootNode);
        output = output.TrimEnd(' ');
        output = output.TrimEnd(',');
        Console.WriteLine(output);
    }

    public void PostOrderTraversalOfBinaryTree(Node node)
    {
        if (node == null)
            return;

        // Print recursively left subtree
        PostOrderTraversalOfBinaryTree(node.LeftNode!);

        // Print recursively right subtree
        PostOrderTraversalOfBinaryTree(node.RightNode!);

        // Print the root Node
        output += node.Value + ", ";
    }
}