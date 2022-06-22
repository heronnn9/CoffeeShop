using System;
using CoffeeShop;
using CoffeeShop.CoffeTypes;

public class Program
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("***************************");
        Console.WriteLine("Welcome to Coffee Shop");
        Console.WriteLine("***************************");
        Console.WriteLine("Coffee Prices :\n" +
            "Latte : 10$\n" +
            "Mocha : 15$\n" +
            "Filtred Coffee : 15$ \n" +
            "Turkish Coffee : 5$");
        Console.WriteLine("****************************");
        Console.WriteLine("Extra Prices : \n" +
            "Extra Sugar : 2$\n" +
            "Extra Caramel : 5$\n" +
            "Extra Creame : 5$\n" +
           "Extra Milk : 3$");



        Console.Write("What is your name : ");
        string InputName = Console.ReadLine();


        Console.WriteLine("For Latte press 1 \n" +
            "for Mocha press 2 \n" +
            "for Filtered Coffee press 3 \n" +
            "for Turkish Coffee press 4\n" +
            "press q for exit the Coffe Shop");

        string order = Console.ReadLine();
        if (order == "1")
        {
            Latte latte = new(1, "Latte", "Contain Caffeine", 10, true, true,true);

            Console.WriteLine("If it's hot press 1");
            Console.WriteLine("If it's cold press 2");
            string LatteisHot = Console.ReadLine();

            latte.CoffeMakeHot(LatteisHot == "1");
            if(LatteisHot == "1")
            {
                latte.Price += 2;
            }
            
            Console.WriteLine("Do you want Extra Caramel\n" +
                "if you want press 1\n" +
                "Else press 2 ");
            string LatteIsCaramel = Console.ReadLine();
            latte.IsCarammel(LatteIsCaramel == "1");
            if(LatteIsCaramel == "1")
            {
                latte.Price += 5;
            }

            Console.WriteLine("If you want milk press 1");
            Console.WriteLine("Else press 2");
            string MilkedLatte = Console.ReadLine();
            latte.IssMilked(MilkedLatte == "1");

            if (MilkedLatte == "1")
            {
                latte.Price += 5;
            }



            
            latte.MakeCoffee(latte);
            Console.WriteLine("***********************");
            Console.WriteLine(InputName + " Your Coffee is Ready");
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffee With Caramel : " + latte.CaramelText());
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffee Hot : " + latte.CoffeeHotText());
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffe Milked : " + latte.MilkedText());
            Console.WriteLine("***********************");
            Console.WriteLine("You have to pay : "+ latte.Price + " $");
            Console.WriteLine("Bon Appetite");
            Console.WriteLine("***********************");

        }
        else if (order == "2")
        {
            Mocha mocha = new(1, "Mocha", "Contains Caffeine", 15, false, false,false);
           
            Console.WriteLine("If it's hot press 1\n" +
                "If it's cold press 2 ");
            string MochaIsHot = Console.ReadLine();

            mocha.CoffeMakeHot(MochaIsHot == "1");

            if (MochaIsHot == "1")
            {
                mocha.Price += 2;
            }
            Console.WriteLine("Do you want Extra Creame\n" +
                "if Do you want press 1\n" +
                "Else press 2 ");
            string MochaIsCreamed = Console.ReadLine();
            mocha.IsCreammm(MochaIsCreamed == "1");

            if(MochaIsCreamed == "1")
            {
                mocha.Price += 3;
            }
            Console.WriteLine("If you want milk press 1");
            Console.WriteLine("Else press 2");
            string MilkedMocha = Console.ReadLine();
            mocha.IssMilked(MilkedMocha == "1");

            if(MilkedMocha == "1")
            {
                mocha.Price += 5;
            }



            
            mocha.MakeCoffee(mocha);
            Console.WriteLine("***********************");
            Console.WriteLine(InputName + " Your Coffee is Ready");
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffee With Creame : " + mocha.CreameText());
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffee Hot : " + mocha.CoffeeHotText());
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffe Milked : " + mocha.MilkedText());
            Console.WriteLine("***********************");
            Console.WriteLine("You have to pay : " + mocha.Price + " $");
            Console.WriteLine("Bon Appetite");
            Console.WriteLine("***********************");

        }
        else if (order == "3")
        {
            FiltreCoffee filtreCoffee = new (3, "Filtred Coffee", "Contains Caffeine", 20, false,false);
            Console.WriteLine("If it's hot press 1");
            Console.WriteLine("If it's cold press 2");
            string FCoffee = Console.ReadLine();

            

            filtreCoffee.CoffeMakeHot(FCoffee == "1");
             
            Console.WriteLine("If you want milk please press 1 ");
            Console.WriteLine("Else press 2");
            string MFCoffee = Console.ReadLine();
            filtreCoffee.IssMilked(MFCoffee == "1");
            if(MFCoffee == "1")
            {
                filtreCoffee.Price += 5;
            }


            
            filtreCoffee.MakeCoffee(filtreCoffee);
            Console.WriteLine("***********************");
            Console.WriteLine(InputName + " Your Coffee is Ready");
            Console.WriteLine("***********************");
            Console.WriteLine("Is the Coffee Hot : " + filtreCoffee.CoffeeHotText());
            Console.WriteLine("***********************");
            Console.WriteLine("You have to pay : " + filtreCoffee.Price + " $");
            Console.WriteLine("Bon Appetite");
            Console.WriteLine("***********************");

        }
        else if (order == "4")
        {
            TurkishCoffee turkishCoffee = new(4, "Turkish Coffee", "Made in Turkey", 5,false);


            Console.WriteLine("Do You want sugar in your Turkish Coffee");
            Console.WriteLine("If you want press 1\n" +
                "else press 2");
            string SugarTurkishCoffee = Console.ReadLine();
            turkishCoffee.IssSugar(SugarTurkishCoffee == "1");

            if(SugarTurkishCoffee == "1")
            {
                turkishCoffee.Price += 2;
            }
            
            
            turkishCoffee.MakeCoffee(turkishCoffee);
            Console.WriteLine("***********************");
            Console.WriteLine(InputName + " Your Coffee is Ready");
            Console.WriteLine("***********************");
            Console.WriteLine("Is your coffee with sugar ? " + turkishCoffee.IsSugarText());
            Console.WriteLine("***********************");
            Console.WriteLine("You have to pay : " + turkishCoffee.Price + " $");
            Console.WriteLine("Bon Appetite");
            Console.WriteLine("***********************");

        }
        else
        {
            Console.WriteLine("Bon Appetite");
        }
    }
}
