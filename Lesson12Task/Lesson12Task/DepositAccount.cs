using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class DepositAccount<T, U> : Account<T, U>, IDepositAccount<T, U>
    {
        public DepositAccount(T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
        : base(_balance, _ownerId, _accountType, _isDepositAccount)
        {
        }

        [JsonConstructor]
        public DepositAccount(long AccountNumber, T _balance, int _ownerId, string _accountType, Boolean _isDepositAccount)
            : base(AccountNumber, _balance, _ownerId, _accountType, _isDepositAccount)
        {
        }
    }
}
