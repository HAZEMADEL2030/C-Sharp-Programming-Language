namespace _21_Classes_and_Objects
{
    class Car
    {
        //Fields
        int ID;
        string Color;
        string Model;


        //Methods
        public void initialize(int id, string color, string model)
        {
            ID = id;
            Color = color;
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("ID is:{0}\nColor is:{1}\nModel is:{2}", ID, Color, Model);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.initialize(1, "Black", "Mercedes");
            myCar.ShowDetails();
            Console.ReadKey();
        }
    }
}