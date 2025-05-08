class Program
{
	static void Main(string[] args)
	{//Data Source
		string[] words =
		{
			"the","quick","brown","fox","jumps"
		};
		//query
		var query = from word in words  orderby word descending select word;

		foreach(var word in words)
		{
			Console.WriteLine(word);
		}
		Console.WriteLine("---------------------------------------------------------------------------");
		Console.ReadKey();

		var wordss= from word in words orderby word.Length descending select word;

		foreach (var word in wordss)
		{
			Console.WriteLine(word);
		}
		Console.WriteLine("---------------------------------------------------------------------------");

		Console.ReadKey();

		Console.WriteLine("fetch the first character of a string");
		var sentence = from word in words orderby word.Substring(0,1) descending select word;

		foreach (var word in sentence)
		{
			Console.WriteLine(word);
		}
		Console.ReadKey();
		Console.WriteLine("---------------------------------------------------------------------------");

	}
}
