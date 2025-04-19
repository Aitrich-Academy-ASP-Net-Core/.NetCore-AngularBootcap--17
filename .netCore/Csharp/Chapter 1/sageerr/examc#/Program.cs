namespace examc_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double sum, avg, large, small, a = 0;
            double[] admin = new double[7];
            //Console.WriteLine("enter the first temperature");
            //admin[0] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the second temperature");
            //admin[1] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the third temperature");
            //admin[2] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the fourth temperature");
            //admin[3] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the fifth temperature");
            //admin[4] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the sixth temperature");
            //admin[5] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the seventh temperature");
            //admin[6] = Convert.ToDouble(Console.ReadLine());

            for(int i = 0; i < admin.Length; i++)
            {
                Console.WriteLine("enter the {0}th temperature",i+1);
                admin[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (var s in admin)
            {
                a = a + s;

            }
            Console.WriteLine("sum : " + a);

            //sum = admin[0] + admin[1] + admin[2] + admin[3] + admin[4] + admin[5] + admin[6];

            avg = a / 7;
            Console.WriteLine("average=  " + avg);

            //if (admin[0] > admin[1] && admin[0] > admin[2] && admin[0] > admin[3] && admin[0] > admin[4] && admin[0] > admin[5] && admin[0] > admin[6])
            //{

            //}
            small = admin[0];
            large = admin[0];
            foreach (var num in admin)
            {
                

                if (num < small)
                {
                    small  = num;
                      
                }   
            }
            Console.WriteLine(small + " is the smallest");
            foreach (var abc in admin)
            {
                

                if (abc > large)
                {
                    large = abc;
                    
                    
                }

            }
            Console.WriteLine(large + " is the largest");
        }
    }
}        
            
                
                   
                
            
        
    



        
    


        
