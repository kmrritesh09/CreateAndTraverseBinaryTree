namespace CreateAndTraverseBinaryTree;

public class BinaryTreeCreateOperations : IBinaryTreeCreateOperations
{
    public Node CreateBinaryTree(ushort[] inputNumbers)
    {
        inputNumbers = BinaryTreeHelperMethods.SortArray(inputNumbers);

        Node rootNode = null!;
        rootNode = CreateBST(inputNumbers, 0, (inputNumbers.Length - 1), rootNode);

        return rootNode;
    }

    public Node CreateBST(ushort[] arr, int start, int end, Node root)
    {
        if (start > end)
            return null!;

        int mid = (start + end)/2;

        if (root == null)
            root = new Node(arr[mid]);
        root.LeftNode = CreateBST(arr, start, mid - 1, root.LeftNode!);
        root.RightNode = CreateBST(arr, mid + 1, end, root.RightNode!);

        return root;
    }
}
