// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Algorithms and Data Structures.");

// The greatest common denominator
var gcdObj = new GCD();
var greatestCommonDenominator = gcdObj.FindGCD(12, 4);
Console.WriteLine($"The greatest common denominator for 12 and 4 is {greatestCommonDenominator}.");

// Single linked list
var singleLinkedList = new SingleLinkedList();
Console.WriteLine($"Is the list empty? {singleLinkedList.IsEmpty}");
Console.WriteLine($"The size of the list is {singleLinkedList.Count}");

singleLinkedList.AddNode("first node");
singleLinkedList.AddNode("second node");
singleLinkedList.AddNode(1, "node three");
singleLinkedList.RemoveNode(1);
singleLinkedList.ClearList();

singleLinkedList.AddNode("hello");
singleLinkedList.AddNode("hi");
singleLinkedList.AddNode("hey");
int index = singleLinkedList.IndexOf("hello");

bool containsData = singleLinkedList.ContatinsData("hello");
object greetings = singleLinkedList.GetDataByIndex(0);
object greetings2 = singleLinkedList[1];
Console.ReadLine();

