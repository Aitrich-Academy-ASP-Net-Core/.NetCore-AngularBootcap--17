using InterfaceExample;

class Program
{
    static void Main(string[] args)
    {
        JobSeeker jobSeeker = new JobSeeker();
        jobSeeker.Register();
        jobSeeker.Login();
        JobProvider jobProvider = new JobProvider();
        jobProvider.Login();
    }
}