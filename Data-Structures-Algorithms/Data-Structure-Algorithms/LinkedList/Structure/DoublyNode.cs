namespace DataStructuresAlgorithms.LinkedList.Structure
{
    public class DoublyNode<T>
    {
        public DoublyNode(T value)
        {
            this.value = value;
            this.previous = null;
            this.next = null;
        }

        public T value { get; set; }
        public DoublyNode<T> previous { get; set; }
        public DoublyNode<T> next { get; set; }
    }
}
