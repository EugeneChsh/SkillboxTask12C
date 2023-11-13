using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class Account<T, U> : IAccount<T, U>
    {
        private Random random = new Random();

        private long accountNumber;
        public T Balance { get; set; }
        public int OwnerId { get; set; }
        public string DisplayValue => $"Номер счета: {this.AccountNumber}  Тип счета: {this.AccountType}  Сумма: {this.Balance}";
        public string AccountType { get; set; }
        public Boolean IsDepositAccount { get; set; }

        public Account(T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
        {
            this.accountNumber = random.Next(10000000, 99999999);
            Balance = _balance;
            OwnerId = _ownerId;
            AccountType = _accountType;
            IsDepositAccount = _isDepositAccount;
        }

        [JsonConstructor]
        public Account(long AccountNumber, T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
        {
            this.accountNumber = AccountNumber;
            Balance = _balance;
            OwnerId = _ownerId;
            AccountType = _accountType;
            IsDepositAccount = _isDepositAccount;
        }

        public IAccount<T, U> Deposit(T amount)
        {
            double doubleBalance = Convert.ToDouble(Balance);
            double doubleAmount = Convert.ToDouble(amount);
            doubleBalance += doubleAmount;
            Balance = (T)Convert.ChangeType(doubleBalance, typeof(T));

            return this;
        }

        public long AccountNumber => this.accountNumber;
    }
}
