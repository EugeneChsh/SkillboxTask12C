using Lesson12Task;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class NonDepositAccount<T, U> : Account<T, U>, INonDepositAccount<T, U>
    {
        public NonDepositAccount(T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
        : base(_balance, _ownerId, _accountType, _isDepositAccount)
        {
        }

        [JsonConstructor]
        public NonDepositAccount(long AccountNumber, T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
            : base(AccountNumber, _balance, _ownerId, _accountType, _isDepositAccount)
        {
        }
    }
}