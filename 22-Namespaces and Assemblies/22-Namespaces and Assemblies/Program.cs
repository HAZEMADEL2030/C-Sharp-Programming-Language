namespace _22_Namespaces_and_Assemblies
{
    internal class Program
    {

        class Book
        {
            //Fields
            string Title;
            string Author;
            string Publisher;


            public void initilaize(string title, string author, string publisher)
            {
                this.Title = title;
                this.Author = author;
                this.Publisher = publisher;
            }


            public void ShowDetails()
            {
                Console.WriteLine("Title is:{0}\nAuthor is:{1}\nPublisher is:{2}", Title, Author, Publisher);
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.initilaize("C# Programming Language", "Hazem Adel Mohamed", "International Programming");
            book.ShowDetails();
            Console.Read();
        }
    }
}