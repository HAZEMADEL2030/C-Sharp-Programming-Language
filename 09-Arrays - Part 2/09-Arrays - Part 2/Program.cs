namespace _09_Arrays___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] names = new string[2, 3];
            names[0, 0] = "Hazem";
            names[0, 1] = "Adel";
            names[0, 2] = "Mohamed";

            names[1, 0] = "Mazen";
            names[1, 1] = "Asem";
            names[1, 2] = "Mostafa";

            foreach (string n in names)
            {
                //Display all items in Upper format
                Console.WriteLine("Welome: " + n.ToUpper());
            }

            Console.WriteLine("--------");

            foreach (string n in names)
            {
                //Display all items in Lower format
                Console.WriteLine("Welcome: " + n.ToLower());
            }
            Console.ReadKey();
        }
    }
}