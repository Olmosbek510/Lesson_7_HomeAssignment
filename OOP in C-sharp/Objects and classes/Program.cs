namespace Objects_and_classes;
class Program
{
    static void Main(string[] args)
    {
        //Creating Book Object
        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.author = "JK Rowling";
        book1.pages = 400;
        // Console.WriteLine("object book1 attributes");
        // Console.WriteLine(book1.author);
        // Console.WriteLine(book1.Title);
        // Console.WriteLine(book1.pages);

        // Console.WriteLine("\n\nobject book2 attributes");
        // Book book2 = new Book();
        // book2.Title = "Red Dragon";
        // book2.author = "Thomas Harris";
        // book2.pages = 480;
        // Console.WriteLine(book2.author);
        // Console.WriteLine(book2.Title);
        // Console.WriteLine(book2.pages);
       
        Car toyota = new Car("Nissan"); //Linked to Constructor directly
        toyota.brand = "TOYOTA";
        toyota.color = "White";
        toyota.engine_size = 3000;
        toyota.model = "Corolla";
        toyota.number_of_seats = 5;
        toyota.year = 2019;
        Console.WriteLine(toyota.brand);

        //==============Constructors=============


    }
}

