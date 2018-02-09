using System;

namespace SimpleFactory
{
	/// <summary>
	/// 比萨枚举
	/// </summary>
	public enum PizzaType{
		Cheeese,
		Greek,
		Pepperoni,
		Clam,
		Veggie
	}

	/// <summary>
	/// 简单工厂类
	/// </summary>
	public class SimplePizzaFactory
	{
		public Pizza CreatePizza(PizzaType type){
			if (type == PizzaType.Cheeese) {
				return new CheesePizza ();
			} else if (type == PizzaType.Greek) {
				return new GreekPizza ();
			} else if (type == PizzaType.Pepperoni) {
				return new PepperoniPizza ();
			} else if (type == PizzaType.Clam) {
				return new ClamPizza ();
			} else if (type == PizzaType.Veggie) {
				return new VeggiePizza ();
			} else
				return null;
		}
	}
}

