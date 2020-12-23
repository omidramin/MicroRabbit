using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _db;

        public TransferRepository(TransferDbContext db)
        {
            _db = db;
        }

        //void ITransferRepository.Add(TransferLog transferLog)
        //{
        //    var transfer = new List<TransferLog>();
        //    transfer.Add(new TransferLog()
        //    {
        //        FromAccount = transferLog.FromAccount,
        //        ToAccount = transferLog.ToAccount,
        //        TransferAmount = transferLog.TransferAmount
        //    });
        //     return transfer;
        //}

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _db.TransferLogs;
        }

        public IEnumerable<TransferLog> Add(TransferLog transferLog)
        {
            var transfer = new List<TransferLog>();
            transfer.Add(new TransferLog()
            {
                FromAccount = transferLog.FromAccount,
                ToAccount = transferLog.ToAccount,
                TransferAmount = transferLog.TransferAmount
            });
            return transfer;
        }

        //void ITransferRepository.Add(TransferLog transferLog)
        //{
        //    return transferLog;
        //}
    }
}
