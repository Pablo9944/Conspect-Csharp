using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var summary = BenchmarkRunner.Run<Testing>();
		}
    }
	public class Testing
	{
		[Benchmark]
		public void CreateMatrix()
		{
			int n = 10000;

			var matrix = new int[n][];

			for (int i = 0; i < n; i++)
			{
				matrix[i] = new int[n];
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrix[i][j] = i + j;
				}
			}
		}
	}
}
