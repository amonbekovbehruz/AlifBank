using AlifBank.Common.Enums;

namespace AlifBank.Common.Helpers
{
    public class CalculatePercentage
    {
        public static double calculatePercentage(ProductType type, int leasingPeriod, int price) { 
            switch (type)
            {
                case ProductType.TV:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for TV 
                        return price += price *(((leasingPeriod / 3) - 6) * 5/100);
                    }
                    else { 
                        return price += price * (5/100);
                    }

                case ProductType.Smartphone:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for Smartphone
                        return price += price * (((leasingPeriod / 3) - 6) * 3 / 100);
                    }
                    else
                    {
                        return price += price * (3 / 100);
                    }

                case ProductType.Computer:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for Computer
                        return price += price * (((leasingPeriod / 3) - 6) * 4 / 100);
                    }
                    else
                    {
                        return price += price * (4 / 100);
                    }
               
                default: return price;
            }
        }
    }
}
