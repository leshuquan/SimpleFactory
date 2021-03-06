﻿using System;

namespace SimpleFactory
{
	/// <summary>
	/// 创建者类
	/// </summary>
	public class PizzaStore		
	{
		SimplePizzaFactory factory;

		public PizzaStore (SimplePizzaFactory factory)
		{
			this.factory = factory;
		}

		public Pizza orderPizza(PizzaType type){
			Pizza pizza;
			pizza = factory.CreatePizza (type);

			pizza.Prepare ();
			pizza.Bake ();
			pizza.Cut ();
			pizza.Box ();

			return pizza;
		}
	}
}

