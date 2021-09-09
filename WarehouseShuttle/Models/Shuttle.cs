namespace WarehouseShuttle.Models
{
    public static class Shuttle
    {
        public static int Height = 25;
        public static int Width = 25;

        public static StoragePoint3D Position { get; set; }
        public static bool HasPackage { get; set; }
    }
}
