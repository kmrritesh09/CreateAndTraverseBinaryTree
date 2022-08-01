// See https://aka.ms/new-console-template for more information
using CreateAndTraverseBinaryTree;

Console.WriteLine("Please enter the input elements seperated by comma. Take note that only positive integers are accepted!");

string lineOfNumbers = Console.ReadLine()!;

BinaryTreeAssignment treeAssignment = new BinaryTreeAssignment(new BinaryTreeCreateOperations(), new BinaryTreeTraverseOperations());
treeAssignment.ProcessBinaryTreeAssignment(lineOfNumbers);

Console.WriteLine();
Console.WriteLine("Please press enter to close the application");
Console.ReadLine();
