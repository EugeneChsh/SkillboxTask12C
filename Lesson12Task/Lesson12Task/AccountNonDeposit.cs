using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Lesson12Task
{
    public class AccountNonDeposit : IAccount
    {
        private Random random = new Random();

        private long accountNumber;
        public double Ammount { get; set; }
        public int OwnerId { get; set; }
        public string DisplayValue => $"Номер счета: {this.AccountNumber}      Сумма: {this.Ammount}";

        public AccountNonDeposit(double _ammount, int _ownerId) 
        {
            this.accountNumber = random.Next(10000000, 99999999);
            Ammount = _ammount;
            OwnerId = _ownerId;
        }

        [JsonConstructor]
        public AccountNonDeposit(long AccountNumber, double _ammount, int _ownerId)
        {
            this.accountNumber = AccountNumber;
            Ammount = _ammount;
            OwnerId = _ownerId;
        }

        public long AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }
    }
}
