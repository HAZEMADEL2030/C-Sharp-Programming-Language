namespace _18_Passing_Parameters_By_Reference_and_Output
{
    internal class Program
    {

        static void myProc(ref int Number)
        {
            Number = 6;
            Console.WriteLine("Value during passing is :" +
            Number);
        }

        static void myProc2(out int Number)
        {
            Number = 8;
            Console.WriteLine("Value during passing is :" +
            Number);
        }
        static void Main(string[] args)
        {
            int Num = 10;
            int Num2;
            Console.WriteLine("Value Before passing is :" + Num);
            //ref needs an initial value of parameter
            myProc(ref Num);
            Console.WriteLine("Value After passing is :" + Num);

            //out does'nt need an initial value of parameter
            myProc2(out Num2);
            Console.ReadKey();
        }
    }
}