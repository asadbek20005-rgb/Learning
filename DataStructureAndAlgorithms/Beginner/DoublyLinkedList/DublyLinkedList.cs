namespace DataStructureAndAlgorithms.Beginner.DoublyLinkedList;

public class DublyLinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    public DublyLinkedList()
    {
        Head = null;
        Tail = null;
    }

    // Oxiriga element qo'shish

    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if(Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Pre = Tail;
            Tail = newNode;
        }
    }

    // Boshi element qo'shish

    public void AddFirst(int data)
    {
        Node newNode = new Node(data);

        if(Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Pre = newNode;
            Head = newNode;
        }
    }

    // Ro'yxatni oldindan oxirigacha chiqarish

    public void PrintForward()
    {
        Node current = Head;
        while(current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Ro'yxatni oxiridan boshlab chiqarish
    public void PrintBackward()
    {
        Node current = Tail;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Pre;
        }
        Console.WriteLine();
    }
}
