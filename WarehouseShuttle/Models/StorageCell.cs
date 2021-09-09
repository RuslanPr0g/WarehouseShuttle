namespace WarehouseShuttle.Models
{
    public class StorageCell
    {
        public static int Height = 32;
        public static int Width = 32;

        public int Number { get; set; }
        public bool HasPackage { get; set; }
        public decimal MaxMass { get; set; }
        public StoragePoint3D Location { get; set; }
    }
}
