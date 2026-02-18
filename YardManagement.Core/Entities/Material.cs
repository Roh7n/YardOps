using System;
using System.Collections.Generic;
using System.Text;

namespace YardManagement.Core.Entities
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Unit { get; set; } = "CFT";
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
