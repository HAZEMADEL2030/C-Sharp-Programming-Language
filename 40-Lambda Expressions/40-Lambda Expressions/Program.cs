namespace _40_Lambda_Expressions
{
    public delegate void mydelegate();
    class Absence
    {
        public event mydelegate AbsenceEvent;
        private int Absented_Hours;

        public int Absented_Hours_Property
        {
            get { return Absented_Hours; }
            set { Absented_Hours = value; }
        }

        public Absence(int Hours)
        {
            this.Absented_Hours = Hours;
        }

        public void VerifyAbsence(int Max_Hours)
        {
            if (Absented_Hours > Max_Hours)
            {
                AbsenceEvent();
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Example:
            Absence absence = new Absence(10);
            absence.AbsenceEvent += () => Console.WriteLine("Warning");
            absence.VerifyAbsence(8);
            Console.ReadKey();
            //Second Example:
            List<string> Colors = new List<string> { "Red", "Green", "Black", "Yellow", "Orange" };
            Console.Write("Colors are:\n");
            Colors.ForEach(kk =>
            {
                Console.WriteLine("\t - " + kk);
            });
            Console.ReadKey();
        }
    }
}