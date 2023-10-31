namespace _03_Flow_Control_If_Else_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            double div;

            Console.Write("Enter the First Number:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number:");
            number2 = int.Parse(Console.ReadLine());

            if (number2 == 0)
            {
                Console.Write("Cannot Divide By Zero");
            }
            else
            {
                div = number1 / number2;
                Console.Write("The Quotient of Division is: " + div);
            }
            Console.ReadKey();
        }
    }
}