namespace CoffeeShop.CoffeeFeatures
{
    public interface IsMilked
	{
		public bool IsMilked { get; set; }
		string MilkedText();
		void IssMilked(bool IsMilked);
	}
}

