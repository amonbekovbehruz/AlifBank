﻿using AlifBank.Entities;

namespace AlifBank.Common.Helper
{
    public static class SendSMS
    {
        public static string SendDetailsSMS(Item item) {
            return $"Dear Customer {item.PhoneNumber}, your order successfully added! Here are the details: " +
                $"\nItem: {item.Id}, " +
                $"\nName: {item.Name}, " +
                $"\nInitial Price: {item.Price}, " +
                $"\nPrice to Pay {item.PriceToPay}, " +
                $"\nLeasing Period {item.LeasingPeriod}";
        }
    }
}
