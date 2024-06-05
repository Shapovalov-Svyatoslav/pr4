internal class Program
{
	private static void Main(string[] args)
	{
		double x = 3.4, a = 82, b = 2.5;
		double y = (Math.Abs(x) + 8) / (Math.Pow(x, 3) + 18);
		double n = Math.Pow(y + 15, 0.25);
		double z = (n + a) / (Math.Cos(b) + n);

		Console.WriteLine("y = " + Math.Round(y, 2));
		Console.WriteLine("z = " + Math.Round(z, 2));
	}
}