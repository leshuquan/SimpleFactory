using System;

namespace SimpleFactory
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			SimplePizzaFactory factory = new SimplePizzaFactory ();
			PizzaStore client = new PizzaStore (factory);

			client.orderPizza (PizzaType.Cheeese);
			client.orderPizza (PizzaType.Greek);
		}
	}
}
