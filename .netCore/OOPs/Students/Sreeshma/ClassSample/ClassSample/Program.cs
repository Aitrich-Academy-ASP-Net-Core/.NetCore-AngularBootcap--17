namespace ClassSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Student student1 = new Student("Reshma",29);
            //Student student2 = new Student();
            //student1.Name = "Saniyo";
            //student1.Age = 30;
            //student1.SetTotalMarks();
            //student1.PrintStudentDetails();
            //student2.PrintStudentDetails();

            Book book1 = new Book();
            Book book2 = new Book("The Bird with Golden Wings","Sudha Murthy","Rs. 300/-","Sep 2020");
            book1.BookDetails();
            book2.BookDetails();

        }
    }
}
