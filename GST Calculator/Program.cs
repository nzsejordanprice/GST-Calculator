using System;

namespace SalesTax
{
    class gstCalculator
    {
        static void Main(string[] args) 
        {
            
            Console.WriteLine("Enter Product name: ");
            string product = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product Price :");
            double userPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is this GST inclusive?(Y/N) :");
            char gstADD = Convert.ToChar(Console.ReadLine());

            if ((gstADD == 'Y') || (gstADD == 'y'))
            {
                Console.Write(product);
                double gst = (userPrice * 0.1304);
                Console.WriteLine("The GST will be = $" + gst);
                double totalPrice= (userPrice - gst); 
                Console.WriteLine("Gst exclusive Total = $" + totalPrice);
                double total = (quantity * totalPrice);
                Console.WriteLine("Total order excluding gst" + total);
                double total2 = (quantity * userPrice);
                Console.WriteLine("Total order including gst" + total2);

            }
            else if ((gstADD == 'N') || (gstADD == 'n'))
            {
                Console.Write(product);
                double gst = (userPrice * 0.15);
                Console.WriteLine("The GST will be = $" + gst);
                double totalPrice = (gst + userPrice);
                Console.WriteLine("Gst inclusive Total = $" + totalPrice);
                double total = (quantity * totalPrice);
                Console.WriteLine("Total order including gst" + total);
                double total2 = (quantity * userPrice);
                Console.WriteLine("Total order excluding gst" + total2);

            }
            else
            {
                Console.WriteLine("Invalid input entered");
            }
        }
    }
}