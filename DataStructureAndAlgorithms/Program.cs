using DataStructureAndAlgorithms.Beginner.Array;
using DataStructureAndAlgorithms.Beginner.SinglyLinkedList;
using DataStructureAndAlgorithms.Beginner.String;

var signlyLinkedList = new SinglyLinkedList<int>();

signlyLinkedList.Add(1);
signlyLinkedList.Add(2);
signlyLinkedList.Add(3);
signlyLinkedList.Add(4);
signlyLinkedList.Add(5);

foreach(var item in signlyLinkedList)
{
    Console.WriteLine(item);
}