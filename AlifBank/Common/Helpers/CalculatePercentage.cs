using AlifBank.Common.Enums;

namespace AlifBank.Common.Helpers
{
    public class CalculatePercentage
    {
        public static double calculatePercentage(ProductType type, int leasingPeriod, int price) { 
            double res = price;
            switch (type)
            {
                case ProductType.TV:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for TV 
                        return res += price * (((leasingPeriod / 3) - 6) * 5.0/100);
                    }
                    else { 
                        return res += price * (5.0/100);
                    }

                case ProductType.Smartphone:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for Smartphone
                        return res += price * (((leasingPeriod / 3) - 6) * 3.0/100);
                    }
                    else
                    {
                        return res += price * (3.0/100);
                    }

                case ProductType.Computer:
                    if (leasingPeriod > 18)
                    {
                        //                        Calculate the percentage for Computer
                        return res += price * (((leasingPeriod / 3) - 6) * 4.0/100);
                    }
                    else
                    {
                        return res += price * (4.0/ 100);
                    }
               
                default: return price;
            }
        }
    }
}
