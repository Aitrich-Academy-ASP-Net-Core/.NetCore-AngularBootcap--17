internal class Program
{
    struct Patient
    {
        public int Id;
        public string Name;
        public int Age;
    }







    private static void Main(string[] args)
    {
        Patient[] patients = new Patient[5];

        Console.WriteLine("**********************PATIENT DATA********************");


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the Patient ID");
            patients[i].Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient Name");
            patients[i].Name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            patients[i].Age=Convert.ToInt32(Console.ReadLine());    






        }

        for (int i = 0;i < patients.Length;i++)
        {
            Console.WriteLine("*******************Details of  Patients********************");
            Console.WriteLine("***********************************************************");

            
            Console.WriteLine("Patient ID is     :"+patients[i].Id);
            Console.WriteLine("Patient Name is   :" + patients[i].Name);
            Console.WriteLine("Patent  Age is    :"+ patients[i].Age);  
        }



       
    }
}