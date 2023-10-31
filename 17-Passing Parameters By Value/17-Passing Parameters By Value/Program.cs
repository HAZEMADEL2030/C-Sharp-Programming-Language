namespace _17_Passing_Parameters_By_Value
{
    internal class Program
    {

        static void myProc(int Number)
        {
            Number = 6;
            Console.WriteLine("Value during passing is :" +
            Number);
        }
        static void Main(string[] args)
        {
            int Num = 10;
            Console.WriteLine("Value Before passing is :" + Num);
            myProc(Num);
            Console.WriteLine("Value After passing is :" + Num);
            Console.ReadKey();
        }
    }
}