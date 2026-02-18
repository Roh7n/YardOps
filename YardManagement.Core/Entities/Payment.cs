using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public decimal Amount { get; set; }
        public string Mode { get; set; } = string.Empty; // Cash / UPI

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }

}
