using System;

namespace Assignment3Solving
{
    class SaleDetails
    {
        // Data members
        public int SalesNo { get; set; }
        public int ProductNo { get; set; }
        public double Price { get; set; }
        public DateTime DateOfSale { get; set; }
        public int Qty { get; set; }
        public double TotalAmount { get; private set; }

        // Constructor to initialize sales details
        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales(); // Calculate TotalAmount when object is created
        }

        // Method to calculate TotalAmount
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        // Static method to display sales details without creating an object
        public static void ShowData(SaleDetails sale)
        {
            Console.WriteLine($"Sales No: {sale.SalesNo}");
            Console.WriteLine($"Product No: {sale.ProductNo}");
            Console.WriteLine($"Price: {sale.Price}");
            Console.WriteLine($"Quantity: {sale.Qty}");
            Console.WriteLine($"Date of Sale: {sale.DateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {sale.TotalAmount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a sale object
            SaleDetails sale = new SaleDetails(1, 101, 50.0, 5, DateTime.Now);

            // Displaying sale data without directly calling an instance method
            SaleDetails.ShowData(sale);

            Console.ReadKey();
        }
    }
}