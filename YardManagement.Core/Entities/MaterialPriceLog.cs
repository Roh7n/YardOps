using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class MaterialPriceLog
    {
        public int MaterialPriceLogId { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; } = null!;

        public decimal Price { get; set; }
        public DateTime EffectiveFromDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
