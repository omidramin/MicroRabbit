using MicroRabbit.Transfer.Domain.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
