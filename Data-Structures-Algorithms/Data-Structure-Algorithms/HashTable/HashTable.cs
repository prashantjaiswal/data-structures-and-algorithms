using DataStructuresAlgorithms.Arrays;

namespace DataStructuresAlgorithms.HashTable
{
    public class HashTable<T>
    {
        private readonly int size;
        private Arrays<Arrays<T>> hashArray;

        public HashTable(int size)
        {
            this.size = size;
            this.hashArray = new Arrays<Arrays<T>>(size);
        }

        private int GenerateHash(string key)
        {
            return key.GetHashCode()/size;
        }

        internal T Get(string key)
        {
            int hash = GenerateHash(key);
            var val = this.hashArray.Get(hash);
            if(val.Count() > 1)
            {

            }
            return default(T);
        }

        internal T Set(string key, T value)
        {
            int hash = GenerateHash(key);
            // var val = this.hashArray.Push(new Arrays<T>(1).Push();


            return default(T);
        }
    }
}
