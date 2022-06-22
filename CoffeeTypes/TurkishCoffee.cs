using System;
using CoffeeShop.CoffeeFeatures;

namespace CoffeeShop.CoffeTypes
{
	public class TurkishCoffee: Coffee,IsSugar
	{
		
		public TurkishCoffee(int Id, string Name, string Description, int Price, bool IsSugar)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Price = Price;
			this.IsHot = IsHot;
			this.IsSugar = IsSugar;
			
		}

		
		public bool IsSugar { get; set; }
        public bool IsHot { get ; set ; }

        public void IssSugar(bool IsSugar)
        {
            this.IsSugar = IsSugar;
        }

		public string IsSugarText() => this.IsSugar ? "Sekerli" : "Sekersiz";
        

        public override void MakeCoffee(Coffee coffee)
        {
            base.MakeCoffee(coffee);
        }

    }
}

