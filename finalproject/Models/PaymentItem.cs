using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalproject.Models
{
    public class PaymentItem
    {
        public int Id { get; set; }
        public string cardOwnerName { get; set; }
        public string cardNumber  { get; set; }
        public Nullable<DateTime> expirationDate { get; set; }
        public string securityCode { get; set; }
    }
}
