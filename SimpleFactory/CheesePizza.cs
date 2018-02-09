using System;
using System.Collections.Generic;

namespace SimpleFactory
{
	/// <summary>
	/// 具体产品类
	/// </summary>
	public class CheesePizza:Pizza
	{
		public CheesePizza ()
		{
			this.name = "NY Style Suce and Cheese Pizza";
			this.dough = "Thin Crust Dough";
			this.sauce = "Marinara Sauce";
			this.toppings.Add ("Grated Reggiano Cheese");
		}
	}
}

