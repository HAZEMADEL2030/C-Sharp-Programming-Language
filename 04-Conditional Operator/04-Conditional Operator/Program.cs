namespace _04_Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conditional Operator
            int number1, number2;

            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            string message = number2 == 0 ? "Cannot Divide By Zero" : "The quotient is:" + number1 / number2; ;

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}