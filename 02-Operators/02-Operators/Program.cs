namespace _02_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Arithmetic Opertaors*/

            //addition
            int sum = 3 + 6;
            //Subtraction
            int difference = 3 - 6;
            //multiplication
            int product = 6 * 2;
            //division
            double quotient = 40 / 5;
            //Exponentiation
            double expo = Math.Pow(10, 7);
            //modulus
            double modulo = 10 % 3;

            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Difference is: " + difference);
            Console.WriteLine("Product is: " + product);
            Console.WriteLine("Quotient is: " + quotient);
            Console.WriteLine("Exponential is: " + expo);
            Console.WriteLine("modulus is: " + modulo);


            /*2.Comparison operators*/

            //result1=true because 4 is greater than 2
            bool result1 = 4 > 2;
            //result2=false because 5 is not less then 1
            bool result2 = 5 < 1;
            //result3=true becaus 10 and 5 are not equal
            bool result3 = 10 != 5;
            //result4=true becaus 3 and 6/2 are equal
            bool result4 = 3 == 6 / 2;

            Console.WriteLine("Result1 is: " + result1);
            Console.WriteLine("Result2 is: " + result2);
            Console.WriteLine("Result3 is: " + result3);
            Console.WriteLine("Result4 is: " + result4);


            //3. Logical Operators

            /*And (&&) operator: Performs an And operation :
            result1 is true because all conditions are true
            */
            bool res1 = (2 > 1 && 4 > 2);

            /*Or (||) operator: Performs an Or operation
            result2 is true because there is a true condition
            */
            bool res2 = (2 > 3 || 1 < 2);


            Console.WriteLine("Result1 is: " + res1);
            Console.WriteLine("Result2 is: " + res2);

            Console.ReadLine();


        }
    }
}