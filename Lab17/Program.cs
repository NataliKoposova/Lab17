using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long accountNumber1 = 2020200220202020;
            double balance1 = 100000;
            string owner1 = "Копосова Наталия Александровна";
            string accountNumber2 = "SBER_00000001";
            double balance2 = 200000;
            string owner2 = "Копосова Елена Александровна";
            BankAccount<long> intAccount = new BankAccount<long>(accountNumber1, balance1, owner1);
            BankAccount<string> stringAccount = new BankAccount<string>(accountNumber2, balance2, owner2);
            intAccount.ShowData();
            stringAccount.ShowData();
            Console.ReadKey();  
        }
        
    }
    
}
