using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
			InheritedClass i = new InheritedClass(5);
			
        }
    }
	//class BaseClass
	//{
	//	public string Name;
	//	protected string Description;
	//	private int value;

	//	public BaseClass(int value)
	//	{
	//		this.value = value;
	//	}
	//}

	//class InheritedClass : BaseClass
	//{
	//	private int newValue;

	//	public InheritedClass(int newValue) : base(100)
	//	{
	//		this.newValue = newValue;
	//	}
	//}

	class BaseClass
	{
		protected string Name;

		public BaseClass(string name)
		{
			Name = name;
		}
	}

	class DerivedClass : BaseClass
	{
		public string Description;

		public int Counter;

        public DerivedClass( string name, string description): base(name)
		{
			Description = description;

		}
		public DerivedClass(string name, string description,int counter) : base(name)
		{
			Description = description;
			Counter = counter;
		}

	}

	

}
