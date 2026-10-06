using Library;
class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the Book class
        // Note how object name differs from class name.
        Book book = new Book("C# for beginners", "BillGates", 12345678);
        Book book1 = new Book("Ultimate C#", "Microsoft", 55667778);
        Console.WriteLine("Currently available books in the library:");
        book.DisplayInfo();
        book1.DisplayInfo();
        //validation test
        Console.WriteLine("Validation test for empty ISBN and invalid author name:");
        Book book3 = new Book("Java for beginners", "55667778", 0);
        book3.DisplayInfo();

        // create a new instance of the Member class
        // these are new members created using the member class constructor
        Member member = new Member(1, "John Doe", "123 Main St", 123456789);
        Member member1 = new Member(2, "Jane Smith", "456 Elm St", 249176422);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}