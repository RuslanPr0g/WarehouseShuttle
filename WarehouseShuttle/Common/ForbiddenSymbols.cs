using System.IO;

namespace WarehouseShuttle.Common
{
    public static class ForbiddenSymbols
    {
        public static char[] SignUP
        {
            get
            {
                return Path.GetInvalidFileNameChars();
            }
        }
    }
}
