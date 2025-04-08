namespace ExamC_
{
    internal class Program
    {
        struct Inventory
        {
            public int ItemCode;
            public string ItemName;
            public int Quantity;
        }
        static void Main(string[] args)
        {
            Inventory[] items = new Inventory[4];
            Console.WriteLine("Details of Inventory");
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Order of User" + (i + 1));
                Console.WriteLine("Enter the item code");
                items[i].ItemCode= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the item name");
                items[i].ItemName= Console.ReadLine();
                Console.WriteLine("Enter the quantity");
                items[i].Quantity= Convert.ToInt32(Console.ReadLine());



            }
            bool found = false;
            Console.WriteLine("Enter the itemcode to search");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            foreach(var inventory in items)
            {
                if (UserInput == inventory.ItemCode)
                {
                    found = true;
                    Console.WriteLine("The item you search for is" +" "+ inventory.ItemName + "\t\tQuantity :" + " "+inventory.Quantity);
                }
            }
            if (!found)
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
