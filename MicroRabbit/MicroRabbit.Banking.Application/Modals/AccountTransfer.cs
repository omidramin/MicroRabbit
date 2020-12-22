using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Modals
{
    public class AccountTransfer
    {
        public int ToAccount { get; set; }
        public int FromAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
