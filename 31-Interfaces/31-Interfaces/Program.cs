using System.Drawing;

namespace _31_Interfaces
{
    interface Quadrangle
    {
        int width { get; set; }
        int height { get; set; }

        float Area();
    }

    class Rectangle : Quadrangle
    {
        private int width;
        private int height;

        //Constructor with parameters
        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }


        public Rectangle()
        {
        }
        int Quadrangle.width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        int Quadrangle.height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        float Quadrangle.Area()
        {
            return this.width * this.height;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrangle Q = new Rectangle(20, 40);
            float CalculArea = Q.Area();
            Console.WriteLine("The Area is:{0}", CalculArea);
            Console.ReadKey();
        }
    }
}