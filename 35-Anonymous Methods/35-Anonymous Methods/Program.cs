namespace _35_Anonymous_Methods
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
            Absence absence = new Absence(10);

            absence.AbsenceEvent += delegate ()
            {
                Console.WriteLine("Warning !");
            };

            absence.VerifyAbsence(8);
            Console.ReadKey();
        }
    }
}