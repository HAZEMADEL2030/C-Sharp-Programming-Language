namespace _05_Switch_Case_and_Conditonal_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case statement
            int number1, number2;
            double div;

            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            switch (number2)
            {
                case 0:
                    Console.WriteLine("Cannot Divide By Zero !");
                    break;
                default:
                    div = number1 + number2;
                    Console.WriteLine("The quotient is: " + div);
                    break;
            }

            Console.ReadKey();
        }
    }
}