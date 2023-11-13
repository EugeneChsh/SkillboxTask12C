using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public interface IAccount<T, U>
    {
        long AccountNumber { get; }
        T Balance { get; set; }
        int OwnerId { get; set; }
        string AccountType { get; set; }
        Boolean IsDepositAccount { get; set; }

        IAccount<T, U> Deposit(T amount);
    }

    public interface IDepositAccount<T, U> : IAccount<T, U>
    {
    }

    public interface INonDepositAccount<T, U> : IAccount<T, U>
    {
    }
}

