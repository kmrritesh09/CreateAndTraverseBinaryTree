namespace CreateAndTraverseBinaryTree;

public class BinaryTreeAssignment
{
    public IBinaryTreeCreateOperations _binaryTreeCreateOperations = null!;
    public IBinaryTreeTraverseOperations _binaryTreeTraverseOperations = null!;

    public BinaryTreeAssignment(IBinaryTreeCreateOperations binaryTreeCreateOperations, IBinaryTreeTraverseOperations binaryTreeTraverseOperations)
    {
        _binaryTreeCreateOperations = binaryTreeCreateOperations;
        _binaryTreeTraverseOperations = binaryTreeTraverseOperations;
    }

    public void ProcessBinaryTreeAssignment(string lineOfNumbers)
    {
        try
        {
            ushort[] listOfNumbers = NumberReaderExtensions.ReadInputNumbersFromConsole(lineOfNumbers);

            Node rootNode = _binaryTreeCreateOperations.CreateBinaryTree(listOfNumbers);

            string output = _binaryTreeTraverseOperations.TraverseBinaryTree(rootNode);

            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            if (ex is FormatException || ex is OverflowException)
            {
                Console.WriteLine("Please provide input as positive integers only seperated by comma (,)");
            }
            else
            {
                Console.WriteLine("Some error occured while constructing tree");
            }
        }
    }
}
