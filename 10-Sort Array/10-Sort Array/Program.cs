namespace _10_Sort_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One Dimensional Array
            //First way by using the Sort Method

            /*int[] numbers = { 1, 8, 6, 4, 9, 0, 12, 5 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/

            //Second Way by an algorithm
            int[] Array = new int[5];
            int i, j, Temp;
            for (i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Enter The Number: " + i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < Array.Length; i++)
            {
                for (j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                    }
                }
            }
            for (i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("The sorted array is : " + Array[i]);

            }
            Console.ReadKey();
        }
    }
}