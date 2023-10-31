namespace _16_Mathematical_Functions
{
    internal class Program
    {

        //Create a function
        static double Calcul(int a, int b, char op)
        {
            double result;
            switch (op)
            {

                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    return 0;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Addition
            double sum = Calcul(8, 2, '+');

            //soustraction
            double difference = Calcul(8, 2, '-');

            //Multiplication
            double Product = Calcul(8, 2, '*');

            //Disvision
            double Quotient = Calcul(8, 2, '/');

            Console.WriteLine(sum + "  " + difference + "  " + Product + "  " + Quotient);
            Console.ReadKey();
        }
    }
}