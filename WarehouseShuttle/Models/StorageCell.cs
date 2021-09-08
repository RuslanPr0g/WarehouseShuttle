using System.Drawing;

namespace WarehouseShuttle.Models
{
    public class StorageCell
    {
        public int Number { get; set; }
        public bool HasPackage { get; set; }
        public decimal MaxMass { get; set; }
        public Point Location { get; set; }
    }
}
