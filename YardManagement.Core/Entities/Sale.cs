using System;
using System.Collections.Generic;
using System.Net.ServerSentEvents;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public decimal TotalAmount { get; set; }
        public string PaymentType { get; set; } = string.Empty; // Cash/Credit

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}
