using System.Collections;

namespace _38_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Stack.
            Stack stack = new Stack();
            stack.Push("Hazem");
            stack.Push("Adel");
            stack.Push("Mohamed");
            stack.Push("Khalil");

            // Displays the Stack.
            Console.Write("Stack values:");
            PrintValues(stack, '\t');

            // Removes an element from the Stack.
            Console.WriteLine("(Pop)\t\t{0}", stack.Pop());

            // Displays the Stack.
            Console.Write("Stack values:");
            PrintValues(stack, '\t');

            // Removes another element from the Stack.
            Console.WriteLine("(Pop)\t\t{0}", stack.Pop());

            // Displays the Stack.
            Console.Write("Stack values:");
            PrintValues(stack, '\t');

            // Views the first element in the Stack but does not remove it.
            Console.WriteLine("(Peek)\t\t{0}", stack.Peek());

            // Displays the Stack.
            Console.Write("Stack values:");
            PrintValues(stack, '\t');
        }
        public static void PrintValues(IEnumerable myCollection, char mySeparator)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }
    }
}