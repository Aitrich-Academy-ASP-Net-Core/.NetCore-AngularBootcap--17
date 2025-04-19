namespace QuantifierOperations
{
	class Program
	{
		public static void Main(string[] args) {

			var Markets = new[] { new {MarketName="marketA",Fruits=new string[]{"kiwi","cherry","banana" } },
				new { MarketName="marketB",Fruits=new string[]{"melon","mango","orange" } },new { MarketName="marketc",Fruits=new string[]{"kiwi","apple","orange" }
			} };

			var name = from market in Markets
					   where 
					   market.Fruits.All(fruit=>fruit.Length==5)
					   select market.MarketName;
			foreach (var market in name) {

				Console.WriteLine(market);
			}
			var names = from market in Markets where market.Fruits.Any(fruit=>fruit.StartsWith("o"))
					   select market.MarketName;
			foreach (var market in names) {
				Console.WriteLine(market);
			
			}
		}
	}
}
