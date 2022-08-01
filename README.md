# CreateAndTraverseBinaryTree
Creating and Traversing a BST

This solution creates a binary tree from a given list of comma seperated positive numbers in the console. It then prints the tree in post order traversal

1) How to Build the solution :- 

a) Download the repo and unzip it.
b) Open CreateAndTraverseBinaryTree.sln in visual studio 2022.
c) Install .Net 6.0 SDK since visual studio 2022 supports it and I have build the soln. in that. (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Note :- It might work with other versions too but that's the version I had targeted when building the solution.

d) Rebuild the soln. in visual studio 2022. The rebuild should restore the nuget packages, important one being Microsoft.VisualStudio.TestTools.UnitTesting and Moq
e) There are two ways to run the program. Either run the project by selecting CreateAndTraverseBinaryTree as startup project and running it from the menu bar at the top of visual studio
f) Alternatively after building you could navigate to "{project_folder/CreateAndTraverseBinaryTree\bin\Debug\net6.0}" in cmd and running CreateAndTraverseBinaryTree.exe
g) To run the unit tests, at the top of visual studio, there is a menu bar, go to Test -> Test Explorer and Run All Tests
