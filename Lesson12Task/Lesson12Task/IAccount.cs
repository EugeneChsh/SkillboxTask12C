using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public interface IAccount
    {
        long AccountNumber { get; }
        double Ammount { get; set; }
        int OwnerId { get; set; }

    }
}
