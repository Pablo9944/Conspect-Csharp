
using _2._6_Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

	using System;

	class MainClass
	{
		public static void Main(string[] args)
		{

			//Результат 2 в 3 степени
			Console.WriteLine(PowerUp(2, 3));
		}

		public static int PowerUp(int N, byte pow)
		{
			if (pow == 0)
			{
				return 1;
			}
			else
			{
				if (pow == 1)
				{
					return N;
				}
				else
				{
					return N * PowerUp(N, --pow);
				}
			}
		}
	}

}






