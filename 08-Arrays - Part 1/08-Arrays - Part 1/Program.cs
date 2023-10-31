namespace _08_Arrays___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of strings
            string[] name = new string[4];

            //Populate the array
            name[0] = "Hazem";
            name[1] = "Adel";
            name[2] = "Mohamed";
            name[3] = "Khalil";

            //display the items of array with for loop
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Welcome : " + name[i]);
            }

            Console.WriteLine();

            //display the items of array with foreach loop
            foreach (string n in name)
            {
                Console.WriteLine("Welcome: " + n);
            }
            Console.ReadKey();
        }
    }
}