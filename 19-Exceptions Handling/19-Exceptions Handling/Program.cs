namespace _19_Exceptions_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 89, b = 0;
                double div = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed Forever !");
            }

            Console.ReadKey();
        }
    }
}