using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	// C# program to demonstrate the method overriding
	// without using 'virtual' and 'override' modifiers
	using System;

	// base class name 'baseClass'
	public class MethodOverriding

	{
		public void show()
		{
			Console.WriteLine("Base class");
		}
	}

	// derived class name 'derived'
	// 'baseClass' inherit here
	public class MethodOverriding2 : MethodOverriding
	{

		// overriding
		new public void show()
		{
			Console.WriteLine("Derived class");
		}
	}

	// C# program to illustrate the use of
	//'virtual' and 'override' modifiers

	class baseClass
	{

		// show() is 'virtual' here
		public virtual void show()
		{
			Console.WriteLine("Base class");
		}
	}


	// class 'baseClass' inherit
	// class 'derived'
	class derived : baseClass
	{

		//'show()' is 'override' here
		public override void show()
		{
			Console.WriteLine("Derived class");
		}
	}


			
}

