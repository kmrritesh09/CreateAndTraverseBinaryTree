// See https://aka.ms/new-console-template for more information
using CreateAndTraverseBinaryTree;

Console.WriteLine("Please enter the input elements seperated by comma. Take note that only positive integers are accepted!");

string lineOfNumbers = Console.ReadLine()!;

try
{
    ushort[] listOfNumbers = NumberReaderExtensions.ReadInputNumbersFromConsole(lineOfNumbers);

    Node rootNode = BinaryTreeOperations.CreateBinaryTree(listOfNumbers);

    BinaryTreeOperations.TraverseBinaryTree(rootNode);
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


Console.WriteLine("Please press enter to close the application");
Console.ReadLine();
