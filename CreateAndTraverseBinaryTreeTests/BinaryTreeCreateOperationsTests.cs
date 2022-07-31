using CreateAndTraverseBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
