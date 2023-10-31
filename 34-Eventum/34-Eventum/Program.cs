namespace _34_Eventum
{
    public delegate void orderDelegate();
    class Product
    {
        private string Label;
        private int Quantity;

        //Event Definition
        public event orderDelegate orderEvent;

        //Constructor
        public Product(string label, int quantity)
        {
            this.Label = label;
            this.Quantity = quantity;
        }

        //Properties
        public string Label_Property
        {
            get { return Label; }
            set { Label = value; }
        }

        public int Quantity_Property
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public void order(int Nbr_Products)
        {
            if (Nbr_Products > this.Quantity) orderEvent();
            this.Quantity = this.Quantity - Nbr_Products;
        }

        public void messageEvent()
        {
            Console.WriteLine("This Quantity is not available !");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product("Keyboard", 20);
            prod.orderEvent += new orderDelegate(prod.messageEvent);
            prod.order(60);
            Console.WriteLine(prod.Quantity_Property);
            Console.Read();
        }
    }
}