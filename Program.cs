using System;

namespace MarketStore2

{
    class Program
    {
        static void Main(string[] args)
        {
            Card DiscountCard = new Card();
            DiscountCard.SilverCard(600, 850); //Change the function to change the card you wish to use.
            Console.WriteLine(DiscountCard);


      
        }

        class Card
        {
            private object mathf;

            public void BronzeCard(double turnover, double valueOfPurchase)
            {
                double discountRate;
                double discount;
                double total;

                if (turnover < 100)
                {
                    discountRate = 1;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Bronze Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 0%" + "\nDiscount: $0" + "\nTotal: $" + discount);
                }

                else if (turnover >= 100 && turnover <= 300)
                {

                    discountRate = 0.01;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Bronze Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 1%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                }

                else if (turnover > 300)
                {
                    discountRate = 0.025;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Bronze Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 2.5%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                }
            }

            public void SilverCard(double turnover, double valueOfPurchase)
            {
                double discountRate;
                double discount;
                double total;

                if (turnover >= 300)
                {
                    discountRate = 0.035;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Silver Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 3.5%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                }

                else
                {
                    discountRate = 0.02;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Silver Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 3.5%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                }
            }


            public void GoldCard(double turnover, double valueOfPurchase)
            {
                double discountRate;
                double discount;
                double total;

                if (turnover < 100)
                {
                    discountRate = 0.02;
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    Console.WriteLine("Gold Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 0%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                }

                else
                {
                    discount = valueOfPurchase * discountRate;
                    total = valueOfPurchase - discount;
                    discountRate = Math.Min(total / 100, 10);
                    Console.WriteLine("Gold Card Selected:\n" + "Turnover: $" + turnover + "\nPurchase value: $" + valueOfPurchase + "\nDiscount Rate: 0%" + "\nDiscount: $" + discount + "\nTotal: $" + total);
                    
                }
              
            }
        }
    }
}
