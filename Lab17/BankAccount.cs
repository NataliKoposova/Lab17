using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class BankAccount <T>
    {
        T accountNumber;
        double balance;
        string ownersName;
        public BankAccount(T accountNumber, double balance, string ownersName)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownersName = ownersName;
        }

        public T GetAccountNumber()
        { return accountNumber; }
        public void SetAccountNumber(T accountNumber)
        { this.accountNumber = accountNumber; }
        public double GetBalance() { return balance; }
        public void SetBalance(double balance)
        { this.balance = balance; }
        public string GetOwnersName() { return ownersName; }
        public void SetOwnersName(string ownersName)
        { this.ownersName = ownersName; }
        public void ShowData()
        {
            Console.WriteLine($"Имя владельца: {ownersName}, баланс: {balance}, номер счета: {accountNumber}");
        }
    }
}
