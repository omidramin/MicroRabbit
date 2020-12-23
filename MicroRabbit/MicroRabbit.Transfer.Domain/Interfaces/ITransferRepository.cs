using MicroRabbit.Transfer.Domain.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        //void Add(TransferLog transferLog);
        IEnumerable<TransferLog> Add(TransferLog transferLog);
    }
}
