namespace SetOperations
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] words = {"hello","hai","helloo","mam" };
			var query =from word in words where word.Length ==3  select word;

			foreach (var word in query) {
			
			Console.WriteLine(word);}
		}
	}

}
