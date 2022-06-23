using System;
namespace CoffeeShop.CoffeTypes
{
    public abstract class Coffee
	{

        public Coffee()
        {

        }       
		

		public Coffee(int Id, string Name , string Description, decimal Price)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Price = Price;

		}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

		public virtual void MakeCoffee(Coffee coffee)
        {
            Console.WriteLine($" {coffee.Name} Hazırlandı.");
        }

    }
	
}

