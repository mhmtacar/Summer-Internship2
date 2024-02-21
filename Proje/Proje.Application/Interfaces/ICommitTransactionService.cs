using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface ICommitTransactionService
    {
        Task<string> CompleteReservation(string TransactionId,string token);
    }
}
