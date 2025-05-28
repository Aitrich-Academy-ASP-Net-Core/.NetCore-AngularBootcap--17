using JobManagement.Manager;
namespace JobManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenuManager mainMenu = new MainMenuManager();
            mainMenu.Start();
        }
    }
}