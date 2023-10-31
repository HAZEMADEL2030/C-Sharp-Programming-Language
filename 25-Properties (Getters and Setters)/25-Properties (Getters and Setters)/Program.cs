namespace _25_Properties__Getters_and_Setters_
{
    class Car
    {
        //Fields
        private int ID;
        private string Color;
        private string Model;

        //Properties
        public int ID_Property
        {
            get { return ID; }
            set { this.ID = value; }
        }

        public string Color_Property
        {
            get { return Color; }
            set { this.Color = value; }
        }

        public string Model_Property
        {
            get
            {
                return this.Model;
            }
            set
            {
                this.Model = value;
            }
        }
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
            Car myCar = new Car(123, "Violet", "Mercedes");
            Console.WriteLine(myCar.Model_Property);
            myCar.Model_Property = "Peugeot";
            Console.WriteLine(myCar.Model_Property);
            Console.ReadKey();
        }
    }
}