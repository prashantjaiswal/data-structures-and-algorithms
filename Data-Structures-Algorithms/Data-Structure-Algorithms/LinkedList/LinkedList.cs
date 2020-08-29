using DataStructuresAlgorithms.LinkedList.Structure;
namespace DataStructuresAlgorithms.LinkedList
{
    public class LinkedList<T>
    {
        public LinkedList(T value)
        {
            this.head = new Node<T>(value);
            this.tail = this.head;
            this.length = 1;
        }

        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }
        public int length { get; private set; }

        public Node<T> Append(T value)
        {
            var newNode = new Node<T>(value);
            this.tail.next = newNode;
            this.tail = newNode;
            this.length += 1;
            return newNode;
        }

        public Node<T> Prepend(T value)
        {
            var newNode = new Node<T>(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length += 1;
            return this.head;
        }

        public Node<T> Insert(T value, int position)
        {
            if (this.length > position)
            {
                var nodeAtPosition = Traverse(position - 1);

                if (nodeAtPosition != default)
                {
                    Node<T> nodeToInsert = new Node<T>(value);
                    nodeToInsert.next = nodeAtPosition.next;
                    nodeAtPosition.next = nodeToInsert;
                    this.length += 1;
                    return nodeToInsert;
                }
                return default; //This would never occur
            }
            else
            {
                this.length += 1;
                return this.Append(value);
            }
        }

        public Node<T> Traverse(int position)
        {
            int currentPosition = 0;
            Node<T> currentNode = this.head;
            while(currentNode.next == null)
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
            var nodeEarlierToRemove = Traverse(position - 1);

            if (nodeEarlierToRemove != default)
            {
                var nodeToRemove = nodeEarlierToRemove.next;
                nodeEarlierToRemove.next = nodeToRemove.next;
                this.length -= 1;
                return true;
            }
            return false;
        }
    }
}
