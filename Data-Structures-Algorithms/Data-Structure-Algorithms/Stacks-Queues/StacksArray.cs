using System;
namespace DataStructuresAlgorithms.StacksQueues
{
    public class StacksArray<T>
    {
        private T[] array = null;

        private int length { get; set; }

        public StacksArray(int size)
        {
            this.array = new T[size];
            this.length = 0;
        }

        public T Peek()
        {
            if(this.length > 0)
                return this.array[this.length - 1];
            return default;
        }

        public T Push(T value)
        {
            if(this.array.Length > this.length)
            {
                this.array.SetValue(value, this.length);
                this.length += 1;
                return value;
            }
            throw new Exception("Size is exceeding the stack length chosen initially");
        }

        public T Pop()
        {
            if(this.length > 0)
            {
                var popped = (T)this.array.GetValue(this.length - 1);
                this.array.SetValue(default, this.length - 1);
                this.length -= 1;
                return popped;
            }
            return default;
        }
    }
}
