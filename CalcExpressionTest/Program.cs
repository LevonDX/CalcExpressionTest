namespace CalcExpressionTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SquareExpressionSolver solver = new SquareExpressionSolver(a: 4, b: -3, c: 9);

			ComplexNum[] result = solver.Calculate();

			double r1 = result[0];

			Console.WriteLine("Roots: {0} and {1}", result[0], result[1]);


			///////////////////////////////
			string[] strs = new string[9];
			int[] ints = new int[9];

			object[] obj = strs;

		}
	}
}