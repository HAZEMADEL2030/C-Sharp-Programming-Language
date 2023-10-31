namespace _14_Listing_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a List
            List<string> myList = new List<string>();

            //Populate a List
            myList.Add("Hazem");
            myList.Add("Adel");
            myList.Add("Mohamed");
            myList.Add("Khalil");


            //Display the items of List
            foreach (string name in myList)
            {
                if (name.Length <= 6)
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadKey();
        }
    }
}