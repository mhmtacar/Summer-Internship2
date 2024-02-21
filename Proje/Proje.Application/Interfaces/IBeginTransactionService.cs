using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface IBeginTransactionService
    {
        Task<string> BeginTransaction(string OfferId, string token);
    }
}
