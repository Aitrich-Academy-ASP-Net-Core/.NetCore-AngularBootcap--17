namespace Linq_Projection
{
	class Program
	{
		public static void Main()
		{
			var words = new string[] { "apple", "orange", "mango" };

			var query =from word in words select word.Substring(0,1);

			foreach (var word in query) {
			
			Console.WriteLine(word);
			}
			//a,o,m

			var sentences = new string[] { "Aitrich technologies ", "the quick brown fox" };
			var querys = from sentence in sentences
						 from word in sentence.Split(' ')
						 select word;

			foreach (var sentence in querys) {
			Console.WriteLine(querys);
			}
			var list1 = new int[] {1,2,3,4};
			var list2 = new string[] { "a", "b", "c"};
			var quer = Enumerable.Zip(list1, list2,(num,letter)=>num.ToString()+letter);

			foreach(var item in query)
			{
				Console.WriteLine(item);
			}

		}
	}
}