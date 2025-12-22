namespace DataStructureAndAlgorithms.Beginner.SinglyLinkedList;

public class SinglyLinkedList<T>
{
    private NodeClass<T> head; // ro'yxatni boshlanishi
    private int count; // ro'yxat uzunligi
  
    public SinglyLinkedList()
    {
        head = null;
        count = 0;
    }

    // Add at the end

    public void Add(T data)
    {
        NodeClass<T> newNode = new NodeClass<T>(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            NodeClass<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
        count++;
    }

    // Add at the beginning
    public void AddFirst(T data)
    {
        NodeClass<T> newNode = new NodeClass<T>(data);
        newNode.Next = head;
        head = newNode;
        count++;
    }

    public bool Remove(T data)
    {
        if (head == null) return false;

        if (head.Data.Equals(data))
        {
            head = head.Next;
            count--;
            return true;
        }

        NodeClass<T> current = head;

        while (current.Next != null && !current.Next.Equals(data))
        {
            current = current.Next;
        }
        if (current.Next == null) return false;

        current.Next = current.Next.Next;

        count--;
        return true;
    }



    // Print all elements

    public void PrintAll()
    {
        var current = head;
        while(current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine("That's it!");
    }


    public int Length()
    {
        return count;
    }


    // Search element
    public bool Contains(T value)
    {
        var current = head;

        while(current != null)
        {
            if(current.Data.Equals(value)) return true;
            current = current.Next;
        }

        return false;   
    }
}
