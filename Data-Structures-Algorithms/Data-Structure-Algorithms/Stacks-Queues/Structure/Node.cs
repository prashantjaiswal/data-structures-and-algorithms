namespace DataStructuresAlgorithms.StacksQueues.Structure
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.next = null;
            this.value = value;
        }

        public Node<T> next { get; set; }
        public T value { get; private set; }
    }
}
