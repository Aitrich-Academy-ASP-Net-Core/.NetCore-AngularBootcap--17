namespace EXAMOOPS07042025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Savingsac sac = new Savingsac();
            sac.Acholder = "SARA";
            sac.Balance = 30000;
            sac.Calcinterest();


            Currentac cac = new Currentac();
            cac.Acholder = "ALEN";
            cac.Balance = 40000;
            cac.Applymainfee(500);

        }
    }
}
