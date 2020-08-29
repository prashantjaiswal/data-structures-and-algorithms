using DataStructuresAlgorithms.LinkedList.Structure;
namespace DataStructuresAlgorithms.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList(T value)
        {
            this.length = 1;
            this.head = new DoublyNode<T>(value);
            this.tail = this.head;
        }

        public int length { get; private set; }
        public DoublyNode<T> head { get; set; }
        public DoublyNode<T> tail { get; private set; }

        public DoublyNode<T> Append(T value)
        {
            var newNode = new DoublyNode<T>(value);
            this.tail.next = newNode;
            newNode.previous = this.tail;
            newNode.next = null;
            this.tail = newNode;
            this.length += 1;
            return newNode;
        }

        public DoublyNode<T> Prepend(T value)
        {
            var newNode = new DoublyNode<T>(value);
            this.head.previous = newNode;
            newNode.next = this.head;
            newNode.previous = null;
            this.head = newNode;
            this.length += 1;
            return this.head;
        }

        public DoublyNode<T> Insert(T value, int position)
        {
            if (this.length > position)
            {
                var priorNode = Traverse(position - 1);
                if (priorNode != default)
                {
                    var nodeToAdd = new DoublyNode<T>(value)
                    {
                        next = priorNode.next,
                        previous = priorNode
                    };
                    priorNode.next = nodeToAdd;
                    this.length += 1;
                    return nodeToAdd;
                }
                return default;
            }
            else
            {
                this.length += 1;
                return this.Append(value);
            }
        }

        public DoublyNode<T> Traverse(int position)
        {
            int currentPosition = 0;
            DoublyNode<T> currentNode = this.head;

            //TODO: Optimization possible by checking position is near to head or tail and traverse from that end 
            while (currentNode.next == null)
            {
                if (currentPosition == position)
                    return currentNode;
                currentNode = this.head.next;
                currentPosition += 1;
            }
            return default;
        }

        public bool Remove(int position)
        {
            var priorNode = Traverse(position - 1);
            if(priorNode != default)
            {
                var nodeToDelete = priorNode.next;
                var nodeNextToOneWeAreDeleting = nodeToDelete.next;
                priorNode.next = nodeNextToOneWeAreDeleting;
                nodeNextToOneWeAreDeleting.previous = priorNode;
                this.length -= 1;
                return true;
            }
            return false;
        }
    }
}
