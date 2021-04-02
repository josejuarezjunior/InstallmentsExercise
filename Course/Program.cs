using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Date(dd / MM / yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm,", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number,date, totalValue) ;

            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(months);

            Console.WriteLine("Installments: ");

        }
    }
}
