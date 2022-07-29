namespace CreateAndTraverseBinaryTree;

public class NumberReaderExtensions
{
    public static ushort[] ReadInputNumbersFromConsole(string lineOfNumbers)
    {
        string[] tokens = lineOfNumbers.Split(',');

        return Array.ConvertAll(tokens, ushort.Parse);
    }

}
