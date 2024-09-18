namespace HashMap
{
    public class HashMap<K, V>
    {
        private class HashNode
        {
            public K key;
            public V value;
            public HashNode next;

            public HashNode(K key, V value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private readonly int capacity;
        private readonly LinkedList<HashNode>[] buckets;
        public HashMap(int capacity)
        {
            this.capacity = capacity;
            buckets = new LinkedList<HashNode>[capacity];
            for (int i = 0; i < capacity; i++)
            {
                buckets[i] = new LinkedList<HashNode>();
            }
        }

        public int GetBucketIndex(K key)
        {
            int hashCode = key.GetHashCode();
            return Math.Abs(hashCode % capacity);
        }

        public void Put(K key, V value)
        {
            int index = GetBucketIndex(key);
            var bucket = buckets[index];
            foreach (var node in bucket)
            {
                if (node.key.Equals(key))
                {
                    node.value = value;
                    return;
                }
            }
            var newNode = new HashNode(key, value);
            bucket.AddLast(newNode);

        }

        public V Get(K key)
        {
            int index = GetBucketIndex(key);
            var bucket = buckets[index];
            foreach (var node in bucket)
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }
            return default(V);
            //or throw exception
            //throw new Exception("Key not found");
        }

        public void Remove(K key)
        {
            int index = GetBucketIndex(key);
            var bucket = buckets[index];
            HashNode nodeToRemove = null;
            foreach (var node in bucket)
            {
                if (node.key.Equals(key))
                {
                    nodeToRemove = node;
                    break;
                }
            }
            if (nodeToRemove != null)
            {
                bucket.Remove(nodeToRemove);
            }
            else
            {
                throw new Exception("Key not found");
            }
        }

        public bool ContainsKey(K key)
        {
            int index = GetBucketIndex(key);
            var bucket = buckets[index];
            foreach (var node in bucket)
            {
                if (node.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main()
        {
            HashMap<string, string> map = new HashMap<string, string>(5);
            map.Put("USA", "Washington DC");
            map.Put("India", "New Delhi");
            map.Put("UK", "London");
            map.Put("Japan", "Tokyo");
            map.Put("France", "Paris");

            Console.WriteLine("Capital of India: " + map.Get("India"));
            Console.WriteLine("Capital of Japan: " + map.Get("Japan"));
            Console.WriteLine("Capital of USA: " + map.Get("USA"));
            Console.WriteLine("Capital of UK: " + map.Get("UK"));
            Console.WriteLine("Capital of France: " + map.Get("France"));

            map.Remove("UK");
            Console.WriteLine("Capital of UK: " + map.Get("UK"));

            Console.WriteLine("Is USA present: " + map.ContainsKey("USA"));
            Console.WriteLine("Is UK present: " + map.ContainsKey("UK"));
        }
    }
}