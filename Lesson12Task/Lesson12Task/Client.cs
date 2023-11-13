using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class Client
    {
        private static int nextId = 1;

        private int id;
        public string FIO { get; set; }
        public string Passport { get; set; }
        public DepositAccount<decimal, decimal> DepositAccount { get; set; }
        public NonDepositAccount<decimal, decimal> NonDepositAccount { get; set; }

        public Client(string _FIO, string _passport)
        {
            this.id = nextId;
            nextId++;
            FIO = _FIO;
            Passport = _passport;
        }

        [JsonConstructor]
        public Client(int Id, string _FIO, string _passport, DepositAccount<decimal, decimal> _depositAccount,
            NonDepositAccount<decimal, decimal> _nonDepositAccount)
        {
            this.id = Id;
            nextId = Id + 1;
            FIO = _FIO;
            Passport = _passport;
            DepositAccount = _depositAccount;
            NonDepositAccount = _nonDepositAccount;
        }

        public int Id { 
            get {
                return this.id;
            }
        }

        public void RemoveAccount(IAccount<decimal, decimal> onRemove)
        {
            if (onRemove.IsDepositAccount) {
                this.DepositAccount = null;
            } 
            else
            {
                this.NonDepositAccount = null;
            }
        }
    }
}
