internal class Program
{ struct Book
    {
        public int Id;
        public string Title;
        public string Author;
    }
    private static void Main(string[] args)
    {

        Book[] book = new Book[2];

        for (int i = 0; i < 2; i++)
        {

            Console.WriteLine("enter the bookid");
            book[i].Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Book Title");
            book[i].Title = Console.ReadLine();

            Console.WriteLine("enter the Book Author");
            book[i].Author = Console.ReadLine();
        }


        for (int i = 0; i < book.Length; i++)
        {
                Console.WriteLine("id "+book[i].Id);
               Console.WriteLine("Title: " +book[i].Title);
                Console.WriteLine(  "Author" +book[i].Author);


        }


        

        foreach (var books in book)
        {

            Console.WriteLine("enter the book id for search");
            int bookid = Convert.ToInt32(Console.ReadLine());


            if (bookid == book[0].Id)
            {
                Console.WriteLine(books.Id);
                Console.WriteLine(books.Title);
                Console.WriteLine(books.Author);


            }

        }




    }
}