namespace _15_Methods__Functions_and_Procedures_
{
    internal class Program
    {

        //Create a Procedure
        static void showMessage(string param)
        {
            Console.WriteLine("Welcome: " + param);
        }

        //Create a function
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Call a Procedure
            showMessage("Hazem");


            //Call a function
            int result = Sum(20, 40);
            Console.WriteLine("The sum is: " + result);

            Console.ReadKey();
        }
    }
}