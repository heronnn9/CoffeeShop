namespace CoffeeShop.CoffeeFeatures
{
    public interface IHot
	{
		bool IsHot { get; set; }

		void CoffeMakeHot(bool isHot);

		string CoffeeHotText();

	}
}

