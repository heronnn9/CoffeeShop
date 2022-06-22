using System;
namespace CoffeeShop.CoffeeFeatures
{
    public interface ICaramel
    {
        bool IsCaramel { get; set; }
        string CaramelText();
        void IsCarammel(bool IsCaramel);
    }
}

