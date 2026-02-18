using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleNumber { get; set; } = string.Empty;

        public decimal Length { get; set; }
        public decimal Breadth { get; set; }
        public decimal Height { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public int customerId { get; set; }
        public Customer Customer { get; set; } = null!;


    }
}
