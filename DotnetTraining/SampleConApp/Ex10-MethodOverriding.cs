using SampleConApp.Util;
using System;
/*
 * When U extend a class into another, U have 2 possibilities for the methods: Add New functions or modify the existing functions.
 * Modifying the existing functions is method overriding. U wish to override(Change) the actual implementation with UR new implementation. 
 * The method that U wish to override should have a modifier called virtual/abstract/override in its base class. 
 * The method U R modifying will be having a modifier called override. Only virtual methods of the base class can be overriden in the derived class.
 * When U override a method, U cannot alter the signature of the base method. U must retain it. 
 */

namespace SampleConApp
{
    enum PaymentMode { Cash, Cheque, Card, UPI }
    class ParentShop //50 Year old shop
    {
        public string DisplayShopDetails()
        {
            var details = "*********SBS Shoping App*********************\nContact Details: XXXX YYYY DDDD ZZZZ\nContact Phone: YYYYY RRRRR\n********************************************";
            return details;
        }
        public virtual void MakePayment(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.Cheque)
            {
                Console.WriteLine("Payment accepted successfully");
            }
            else
            {
                Console.WriteLine("Invalid Mode of Payment, Not accepted");
            }
        }
    }

    class ChildShop : ParentShop
    {
        //It behaves like a new method, not an overriden method. 
        public new string DisplayShopDetails()
        {
            var details = base.DisplayShopDetails();
            details += "Designed by : YYYY RRRR SSSS";
            return details;
        }
        public override void MakePayment(PaymentMode mode, int amount)
        {
            switch (mode)
            {
                case PaymentMode.Cash:
                    Console.WriteLine("Payment by Cash has been successfully made");
                    break;
                case PaymentMode.Cheque:
                    Console.WriteLine("Invalid mode of Payment, Cheques are not accepted");
                    break;
                case PaymentMode.Card:
                    Console.WriteLine("Payment by Credit/Debit card has been successfully made");

                    break;
                case PaymentMode.UPI:
                    Console.WriteLine("Payment via UPI has been successfully made");
                    break;
                default:
                    Console.WriteLine("Invalid mode of payment please select the right option");
                    break;
            }
        }
    }

    internal class ShopFactory
    {
        public static ParentShop CreateShop(string type)
        {
            if (type == "Parent")
                return new ParentShop();
            else if (type == "Child")
                return new ChildShop();
            else
                throw new Exception("Invalid Shop Type");
        }
    }
    internal class Ex10_MethodOverriding
    {
        static void Main(string[] args)
        {
            var type = MyConsole.GetString("Enter the type of the shop U want to create, Type Parent or Child");
            var shop = ShopFactory.CreateShop(type);
            if (shop is ChildShop)
            {
                var child = shop as ChildShop; //Downcasting..
                var board = child.DisplayShopDetails();//Not polymorphic. 
                Console.WriteLine(board);
            }
            else
            {
                var displayBoard = shop.DisplayShopDetails();
                Console.WriteLine(displayBoard);
            }
            shop.MakePayment(PaymentMode.Cash, 5000);
            shop.MakePayment(PaymentMode.Card, 6000);
        }
    }
}
