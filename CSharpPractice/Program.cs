using System;

namespace CSharpPractice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FirstMissingPositiveSol test = new FirstMissingPositiveSol ();
			int[] data = new int[]{1, 2};
			Console.WriteLine (test.FirstMissingPositive(data));
		}
	}
}
