namespace GroupByLinq
{
	class Program
	{
		public static void Main(string[] args) {


			var numbers = new [] { new { number="one",type = "odd"},
				new { number = "two", type = "even" }, 
				new { number = "three", type = "odd" }, };

			var query = from number  in numbers group number by number.type into g
						select new {Type=g.Key ,Count=g.Count() };
			foreach (var number in query)
			{
				Console.WriteLine(number.Type+":"+number.Count	);
			}




		}
	}
}
