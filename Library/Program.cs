using Library;
// This information is for one book in our library
Book book = new Book("C# for beginners", "BillGates", "12345678");
book.DisplayInfo();
// This is another book in our library
Book book1 = new Book("C# Methods & Classes", "Microsoft", "55667778");
book1.DisplayInfo();

Book book2 = new Book("C# for advanced", "Microsoft", "55667778");
book2.DisplayInfo();

//validation test
Book book3 = new Book("Java for beginners", "55667778", "");