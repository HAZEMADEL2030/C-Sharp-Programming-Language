namespace _39_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Hazem");
            names.Enqueue("Adel");
            names.Enqueue("Mohamed");
            names.Enqueue("Ahmed");
            names.Enqueue("Mostafa");

            // A queue can be enumerated without disturbing its contents.
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nDequeuing '{0}'", names.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                names.Peek());
            Console.WriteLine("Dequeuing '{0}'", names.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.
            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            // Create a second queue, using the constructor that accepts an
            // IEnumerable(Of T).
            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string name in queueCopy2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
        }
    }
}