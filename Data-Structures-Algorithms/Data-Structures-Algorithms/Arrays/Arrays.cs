using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Arrays
{
    internal class Arrays<T>
    {
        private readonly int size;
        private T[] array;
        private int currentIndex;

        public Arrays(int size)
        {
            this.size = size;
            this.array = new T[size];
            this.currentIndex = 0;
        }

        internal bool Push( T Value)
        {
            if(this.currentIndex < size)
            {
                this.array.SetValue(Value, currentIndex);
                currentIndex += 1;
                return true;
            }
            return false;
        }

        internal T Pop()
        {
            T popped = this.array[currentIndex];
            this.array.SetValue(default(T), currentIndex);
            this.currentIndex -= 1;
            return popped;
        }

        internal T Get(int index)
        {
            if (this.currentIndex >= index)
            {
                return this.array[index];
            }
            else
                throw new Exception("Value not assigned for the given index..");
        }

        internal int Count()
        {
            return this.currentIndex + 1;
        }
    }
}
