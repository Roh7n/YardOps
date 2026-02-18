using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class SaleItem
    {
        public int SaleItemId { get; set; }

        public int SaleId { get; set; }
        public Sale Sale { get; set; } = null!;

        public int MaterialId { get; set; }
        public Material Material { get; set; } = null!;

        public decimal QuantityCFT { get; set; }
        public decimal RateSnapshot { get; set; }
        public decimal Amount { get; set; }
    }

}
