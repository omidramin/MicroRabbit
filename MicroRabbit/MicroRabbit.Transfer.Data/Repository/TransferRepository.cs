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
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _db.TransferLogs;
        }
        public void Add(TransferLog transferLog)
        {
            _db.TransferLogs.Add(transferLog);
            _db.SaveChanges();
        }
    }
}
