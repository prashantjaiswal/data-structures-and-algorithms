namespace DataStructuresAlgorithms.LinkedList.Structure
{
    public class Node<T>
    {
        public T value { get; private set; }

        public Node<T> next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
