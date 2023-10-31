namespace _06_Loops_the_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Example:
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Hello !");
            }

            Console.WriteLine();

            //Second Example (Multiplication Table):
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}