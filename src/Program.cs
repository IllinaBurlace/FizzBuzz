namespace FizzBuzz {
	public class Program {
		public static void Main(string[] args) {
			if (args.Length > 0) {
				args[0].Replace(",", "");
				int n = int.Parse(args[0]);
				
				bool fizz = false;
				bool buzz = false;

				if (n % 3 == 0) {
					fizz = true;
				}
				if (n % 5 == 0) {
					buzz = true;
				}

				if (!fizz && !buzz) {
					Console.Write(args[0]);
				}

				if (fizz) {
					Console.Write("Fizz");
				}
				if (buzz) {
					Console.Write("Buzz");
				}

				Console.WriteLine();
				return;
			}
		}
	}
}
