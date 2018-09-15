using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop
{
    enum CoffeeSizeType1
    {
        Small = 100, Normal = 150, Double = 300, Overwhelming = 600, Biggest = 1000
    }

    class CoffeeMachine
    {
        private CoffeeSizeType1 cokesize;
        public CoffeeMachine()
        {
            cokesize = CoffeeSizeType1.Normal;
        }

        public CoffeeSizeType1 CokeSize
        {
            set { this.cokesize = value; }
            get { return this.cokesize; }
        }

        public double CalcPrice()
        {
            switch (this.cokesize)
            {
                case CoffeeSizeType1.Small:
                    return 0.20;
                case CoffeeSizeType1.Normal:
                    return 0.40;
                case CoffeeSizeType1.Double:
                    return 0.60;
                case CoffeeSizeType1.Overwhelming:
                    return 0.80;
                case CoffeeSizeType1.Biggest:
                    return 1.0;
                default:
                    throw new InvalidOperationException("Unsupported coffee quantity: " + (int)this.cokesize);
            }
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine HoGuomCoffeeMachine = new CoffeeMachine();
            HoGuomCoffeeMachine.CokeSize = CoffeeSize.Biggest;
            double price = HoGuomCoffeeMachine.CalcPrice() ;
            Console.WriteLine("Price of your coffee is {0}", price);
            Console.WriteLine("Wellcome back");

        }
    }
}
