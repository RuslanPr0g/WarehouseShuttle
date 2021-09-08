using System;

namespace WarehouseShuttle.Models.DTO
{
    public class StorePackageReadDto
    {
        public decimal Mass { get; set; }
        public string Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
    }
}
