using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string ContractorName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


    }
}
