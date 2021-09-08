using System;

namespace WarehouseShuttle.Models
{
    public class Package
    {
        public int Number { get; set; }
        public int StorageCellNumber { get; set; }
        public string PackageInternationalNumber { get; set; }
        public decimal Mass { get; set; }
        public string Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Password { get; set; }
        public bool SoftDeleted { get; set; }
    }
}
