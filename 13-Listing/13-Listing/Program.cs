namespace _13_Listing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a List
            List<int> myList = new List<int>();

            //Populate a List
            myList.Add(6);
            myList.Add(9);
            myList.Add(7);
            myList.Add(2);


            //Remove an item From a List by value:
            myList.Remove(6);

            //Remove an item From a List by index:
            myList.RemoveAt(1);


            //Display the items of List
            foreach (int number in myList)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}