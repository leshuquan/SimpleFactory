using System;

namespace SimpleFactory
{
	public class GreekPizza:Pizza
	{
		public GreekPizza ()
		{
			this.name = "Greek Style Suce and Greek Pizza";
			this.dough = "Thin Pucc Dough";
			this.sauce = "Marinara Sauce";
			this.toppings.Add ("Grated Reggiano Greek");
		}
	}
}

