internal class Program
{

    struct SalesData 
    {
        public double day1;
        public double day2;
        public double day3;
        public double day4;
        public double day5;
        public double day6;
        public double day7;
    }




    private static void Main(string[] args)
    {
    SalesData[] sales = new SalesData[7];

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("enter the sales data of  day  {0}", i + 1);
            sales[i].day1=Convert.ToDouble(Console.ReadLine());

        }
        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("day  {0}" , i+1 +"="+ sales[i].day1);

            sum = sum + sales[i].day1;
        }
        //Console.WriteLine(sum);
        double totalsales = sum / 7;
          Console.WriteLine("Toatal sales=" + totalsales);

        double highsales = sales[0].day1;
        double lowsales = sales[0].day1;
        foreach (var item in sales)
        {
            if (item.day1 > highsales)
            {
             highsales = item.day1;

            }else if (item.day1 < lowsales) 
                { 
                lowsales = item.day1; 
            }   

        }
        Console.WriteLine("highsales="+highsales);
        Console.WriteLine("lowsales = "+lowsales);


        
    }
}