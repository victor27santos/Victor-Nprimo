using System;
using System.Data;

public class Program
{
	public static void Main()
	{
		// Questão 2:
		operate("x / (x + 1)", 5);
		// Questão 3:
		operate("(x * 2 + 1) / (x * 3)", 5);
		// Questão 4:
		printDivisors(7);
	}

	public static void printDivisors(int n)
	{
		int divisors = 0;
		for (int i = n; i > 0; i--)
		{
			if (n % i == 0)
			{
				divisors++;
			}
		}

		if (divisors == 2)
		{
			Console.WriteLine(n + " é um número primo!");
		}
	}

	public static string formatFormula(string formula, int x)
	{
		return formula.Replace("x", Convert.ToString(x));
	}

	public static void operate(string formula, int n)
	{
		DataTable dt = new DataTable();
		double sum = 0;
		double product = 1;
		for (int i = 1; i < n + 1; i++)
		{
			string calc = formatFormula(formula, i);
			double v = (double)dt.Compute(calc, "");
			Console.WriteLine(calc + ": " + +v);
			sum = sum + v;
			product = product * v;
		}

		Console.WriteLine("Soma: " + sum);
		Console.WriteLine("Produto: " + product);
	}
}