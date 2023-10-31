namespace _01_Variables__Constants__Comments__Input___Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Change The Title Of Console Window
            Console.Title = "The First Project";

            //Read a string value
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();


            //Read an integer value
            Console.Write("Enter Your Age:");

            //First Way
            int age = int.Parse(Console.ReadLine());


            /*Second Way:
             * 
            int age = Convert.ToInt16(Console.ReadLine());
         or   int age = Convert.ToInt32(Console.ReadLine());
           or   int age = Convert.ToInt64(Console.ReadLine());*/


            //Print a string to output
            Console.Write("Welcome: " + name + " Your age is: " + age + " That is Great");

            //Pause the console window
            Console.ReadKey();
        }
    }
}