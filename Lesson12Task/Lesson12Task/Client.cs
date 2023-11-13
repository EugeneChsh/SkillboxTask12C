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
        public ObservableCollection<AccountNonDeposit> AccountList { get; set; }

        public Client(string _FIO, string _passport)
        {
            this.id = nextId;
            nextId++;
            FIO = _FIO;
            Passport = _passport;
            AccountList = new ObservableCollection<AccountNonDeposit>();
        }

        [JsonConstructor]
        public Client(int Id, string _FIO, string _passport, ObservableCollection<AccountNonDeposit> _accountList)
        {
            this.id = Id;
            nextId = Id + 1;
            FIO = _FIO;
            Passport = _passport;
            AccountList = _accountList;
        }

        public int Id { 
            get {
                return this.id;
            }
        }
    }
}
