using System.Collections;

namespace _36_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList arraylist = new ArrayList();
            arraylist.Add("Hazem");
            arraylist.Add("Adel");
            arraylist.Add("Mohamed");
            arraylist.Add("Ahmed");
            arraylist.Add("Mostafa");

            arraylist.Remove("Mostafa");
            arraylist.RemoveAt(3);
            arraylist.Sort();

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("arraylist");
            Console.WriteLine("Count:{0}", arraylist.Count);
            Console.WriteLine("Capacity:{0}", arraylist.Capacity);
            Console.WriteLine("Values:");

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}