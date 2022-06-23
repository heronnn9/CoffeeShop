    using System;
using CoffeeShop.CoffeeFeatures;


namespace CoffeeShop.CoffeTypes
{
    public class Latte : Coffee ,IHot,ICaramel,IsMilked
    {
        public Latte(int Id, string Name , string Description , int Price,bool IsHot,bool IsCaramel,bool IsMilked)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.IsHot = IsHot;
            this.IsCaramel = IsCaramel;
            this.IsMilked = IsMilked;

        }

        public bool IsHot { get ; set ; }
        public bool IsCaramel { get; set; }
        public bool IsMilked { get ; set ; }

        public string CaramelText() => this.IsCaramel ? "With Caramel" : "No Caramel";

        

        public string CoffeeHotText() => this.IsHot ? "Sıcak" : "Soğuk";

        public void CoffeMakeHot(bool isHot)
        {
            this.IsHot = isHot;
        }

        public void DoLatte()
        {
            Console.WriteLine("Latte'niz Hazırlanıyor...");
        }

        public void IsCarammel(bool IsCaramel)
        {
            this.IsCaramel = IsCaramel;
        }

        public void IssMilked(bool IsMilked)
        {
            this.IsMilked = IsMilked;
        }

        public string MilkedText() => this.IsMilked ? "Sutlu" : "Sutsuz";
        
    }

}