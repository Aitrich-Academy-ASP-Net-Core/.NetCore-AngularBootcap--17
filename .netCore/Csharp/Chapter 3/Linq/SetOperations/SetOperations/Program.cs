namespace SetOperations
{
	internal class Program
	{
		public static void Main(string[] args) {
			int[] list1 = { 1, 2, 3,5};
			int[] list2 = { 4,5, 6 };
			var numbers = from num in list1.Union(list2) select num;

			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}

			//intersection
			Console.WriteLine(" intersect ");
			var number = from num in list1.Intersect(list2) select num;

			foreach (int num in number)
			{
				Console.WriteLine(num);
			}
			//distinct
			Console.WriteLine("distinct");
			int[] list3 = { 1, 2, 1, 3, 1 };
			var distinct = from num in list3.Distinct() select num;
			foreach(int num in distinct)
			{
				Console.WriteLine(num);
			}
			//Except
			Console.WriteLine("Except");
			var except =
			from num in list1.Except(list3) select num;
			foreach (int num in except)
			{
				Console.WriteLine(num);
			}

		}
	}
}