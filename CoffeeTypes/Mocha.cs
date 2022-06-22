using System;
using CoffeeShop.CoffeeFeatures;


namespace CoffeeShop.CoffeTypes
{
	public class Mocha:Coffee,ICreamed,IHot,IsMilked
	{
		
		public Mocha(int Id, string Name, string Description, int Price,bool IsCreamed,bool IsHot,bool IsMilked)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Price = Price;
			this.IsCreamed = IsCreamed;
			this.IsHot = IsHot;
			this.IsMilked = IsMilked;
		}

        public bool IsCreamed { get ; set ; }
        public bool IsHot { get ; set ; }
        public bool IsMilked { get; set; }

        public string CoffeeHotText() => this.IsHot ? "Sıcak" : "Soğuk";

		public void CoffeMakeHot(bool isHot) => this.IsHot = isHot;

		public string CreameText() => this.IsCreamed ? "Kremalı " : "Kremasız";

		public void IsCreammm(bool IsCream) => this.IsCreamed = IsCream;

        public void IssMilked(bool IsMilked)
        {
			this.IsMilked = IsMilked;
        }

		public string MilkedText() => this.IsMilked ? "Sutlu" : "Sutsuz";
        
    }
}

