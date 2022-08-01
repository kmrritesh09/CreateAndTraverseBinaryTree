namespace CreateAndTraverseBinaryTree;

public class BinaryTreeTraverseOperations : IBinaryTreeTraverseOperations
{
    public string? output { get; set; }
    public string TraverseBinaryTree(Node rootNode)
    {
        output = string.Empty;

        PostOrderTraversalOfBinaryTree(rootNode);
        output = output.TrimEnd(' ');
        output = output.TrimEnd(',');
        return output;
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
