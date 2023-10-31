namespace _30_Overloading_and_Polymorphism
{
    public class Person
    {
	    string FirstName;
        string MiddleName;
        string LastName;
        string Profession;

	public Person()
        {

        }
        Person(string firstname, string middlename, string lastname, string profession)  //constructor
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            Profession = profession;
        }

        public void getInformation()   //class method
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(MiddleName);
            Console.WriteLine(LastName);
            Console.WriteLine(Profession);
        }

        public void setFirstName(string firstname) { FirstName = firstname; }

        // Function to return value of firstname
        // variable firstname
        public string getFirstName() { return FirstName; }

        public void setMiddleName(string middlename) { MiddleName = middlename; }

        // Function to return value of middlename
        // variable middlename
        public string getMiddleName() { return MiddleName; }

        public void setLastName(string lastname) { LastName = lastname; }

        // Function to return value of lastname
        // variable lastname
        public string getLasttName() { return LastName; }

        public void setProfession(string profession) { Profession = profession; }

        // Function to return value of profession
        // variable profession
        public string getProfession() { return Profession; }


        public void kindOfPerson()
        {
            Console.WriteLine("Normal Person");
        }

    };





    class Egyptian : Person
{
	//public:
	//
	//    Egyptian()
	//    {
	//
	//    }
	//
	//    Egyptian(string firstname, string middlename, string lastname, string profession): 
	//        Person(firstname,middlename,lastname,profession)  //constructor
	//    { 
	//
	//    }


	public void kindOfPerson()
    {
            Console.WriteLine("Egyptian Person");
        }

};




class American :  Person
{
    //public:
    //
    //    American()
    //    {
    //
    //    }
    //
    //    American(string firstname, string middlename, string lastname, string profession): 
    //        Person(firstname,middlename,lastname,profession)  //constructor
    //    { 
    //
    //    }

	public void kindOfPerson()
{
            Console.WriteLine("American Person");
        }

};

internal class Program
{

    static void Main(string[] args)
    {
            Person p=new Person();
            p.setFirstName("Hazem");
            p.setMiddleName("Adel");
            p.setLastName("Mohamed");
            p.setProfession("Software Engineer");
            p.getInformation();

            Egyptian e=new Egyptian(); ;
            e.setFirstName("Hazem");
            e.setMiddleName("Adel");
            e.setLastName("Mohamed");
            e.setProfession("Network Engineer");
            e.getInformation();

            American a=new American();
            a.setFirstName("Hazem");
            a.setMiddleName("Adel");
            a.setLastName("Mohamed");
            a.setProfession("Computer Engineer");
            a.getInformation();



            p.kindOfPerson();
            e.kindOfPerson();
            a.kindOfPerson();

        }
    }
}