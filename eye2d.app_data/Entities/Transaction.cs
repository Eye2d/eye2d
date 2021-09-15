using eye2d.app_data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
   public class Transaction
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public int ExternalTransactionId { set; get; }
        public int Amount { set; get; }
        public int ShippingFee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }

    }
}
