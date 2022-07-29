using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndTraverseBinaryTree;

public class BinaryTreeOperations
{
    public static Node CreateBinaryTree(ushort[] inputNumbers)
    {
        inputNumbers = inputNumbers.OrderByDescending(c => c).ToArray();
        Node rootNode = new Node(inputNumbers[0]);

        return rootNode;
    }

    public static void TraverseBinaryTree(Node rootNode)
    {

    }
}
