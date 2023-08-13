using AlifBank.Entities;

namespace AlifBank.Common.Helper
{
    public static class SendSMS
    {
        public static void SendDetailsSMS(Item item) {
            Console.WriteLine($"Dear Customer, your order successfully added! Here are the details: " +
                $"Item: {item.Id}, " +
                $"\nName: {item.Name}, " +
                $"\nInitial Price: {item.Price}, " +
                $"\nPrice to Pay {item.PriceToPay}, " +
                $"\nLeasing Period {item.LeasingPeriod}");
        }
    }
}
