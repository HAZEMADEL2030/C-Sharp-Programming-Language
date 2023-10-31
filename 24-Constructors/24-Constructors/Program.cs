namespace _24_Constructors
{
    class Car
    {
        //Fields
        int ID;
        string Color;
        string Model;


        //Constructors
        public Car(int id, string color, string model)
        {
            this.ID = id;
            this.Color = color;
            this.Model = model;
        }

        public Car()
        {
        }

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
            Car myCar = new Car(1, "White", "Renault");
            myCar.ShowDetails();
            Console.ReadKey();
        }
    }
}