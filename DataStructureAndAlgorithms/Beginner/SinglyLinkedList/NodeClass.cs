namespace DataStructureAndAlgorithms.Beginner.SinglyLinkedList;

public class NodeClass<T>
{
    public T Data { get; set; } // Node ichidagi qiymat
    public NodeClass<T> Next { get; set; } // Keyingi node ga pointer

    public NodeClass(T data)
    {
        Data = data;
        Next = null;  // Default: Keginfi element yo'q.
    }



}
