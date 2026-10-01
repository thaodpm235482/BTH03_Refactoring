using System;

namespace Pattern01_ExtractMethod._3_Real
{
    internal class RealExample
    {
        // Bài toán thực tế: Xử lý và in hóa đơn siêu thị
        public void ProcessOrder(string customerName, double itemPrice, int quantity)
        {
            double subtotal = CalculateSubtotal(itemPrice, quantity);
            double tax = CalculateTax(subtotal);
            double total = subtotal + tax;

            PrintReceipt(customerName, subtotal, tax, total);
        }

        private double CalculateSubtotal(double price, int qty)
        {
            return price * qty;
        }

        private double CalculateTax(double subtotal)
        {
            return subtotal * 0.1; // Thuế VAT 10%
        }

        private void PrintReceipt(string name, double subtotal, double tax, double total)
        {
            Console.WriteLine("=== HÓA ĐƠN THU TIỀN ===");
            Console.WriteLine($"Khách hàng: {name}");
            Console.WriteLine($"Tạm tính: {subtotal:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (10%): {tax:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {total:N0} VNĐ");
            Console.WriteLine("========================");
        }
    }
}