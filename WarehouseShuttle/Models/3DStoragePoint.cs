using System.Drawing;

namespace WarehouseShuttle.Models
{
    public class PointXY
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class StoragePoint3D
    {
        /// <summary>
        /// 3D Height
        /// </summary>
        public int Floor { get; set; }

        /// <summary>
        /// Position relative to boxes (0 - first cell, 1 - second cell, 2..., 3..., etc.) horizontally
        /// </summary>
        public int XPosition { get; set; }

        /// <summary>
        /// Position relative to boxes (0 - first cell, 1 - second cell, 2..., 3..., etc.) vertically
        /// </summary>
        public int YPosition { get; set; }

        /// <summary>
        /// Point of the center of a cell location
        /// </summary>
        public PointXY CenterPointOnPlane { get; set; }

        public StoragePoint3D(int floor, int xpos, int ypos, Point centerpos)
        {
            Floor = floor;
            XPosition = xpos;
            YPosition = ypos;
            CenterPointOnPlane = new PointXY()
            {
                X = centerpos.X,
                Y = centerpos.Y
            };
        }
    }
}
