using System;
using System.Security.Cryptography.X509Certificates;

namespace inheritance
{
    public class Company{

        public Boolean IsNative { get; set; }

        public void Transaction(decimal totalAmount)
        {

            decimal nativePercent = totalAmount * 18 / 100;
            decimal foreignPercent = totalAmount * 5 / 100;

            if (IsNative)
            {
                Console.WriteLine($"You paid: {nativePercent} GEL");
            }
            else
            {
                Console.WriteLine($"You paid: {foreignPercent} GEL");
            }
        }

    }
}
