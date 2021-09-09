using System.Collections.Generic;
using System.Linq;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class MockStoreRepository : IStoreRepository
    {
        #region Tables

        private readonly List<Package> Packages;

        #endregion

        public MockStoreRepository()
        {
            Packages = new List<Package>()
            {
                // ...
            };
        }

        #region Implementation

        public Package GetPackageByNumber(int number)
        {
            return Packages.FirstOrDefault(p => p.Number == number && p.SoftDeleted is false);
        }

        public Package GetPackageByPartOfPINAndOwner(string partOfPIN, string owner)
        {
            return Packages.FirstOrDefault(p =>
            p.PackageInternationalNumber.EndsWith(partOfPIN) && p.Owner == owner && p.SoftDeleted is false);
        }

        public List<Package> GetActualPackages()
        {
            return Packages.Where(p => p.SoftDeleted is false).ToList();
        }

        public List<Package> GetAllPackages()
        {
            return Packages;
        }

        public int StorePackageToDB(Package package)
        {
            Packages.Add(package);
            return package.Number;
        }

        public void UnStorePackageInDB(int packageNumber)
        {
            var indexToUnStore = Packages.FindIndex(p => p.Number == packageNumber);
            Packages[indexToUnStore].SoftDeleted = true;
        }

        public bool IsThereAPackageInStorageCell(int storageCellNumber)
        {
            return Packages.Exists(p => p.StorageCellNumber == storageCellNumber && p.SoftDeleted is false);
        }

        public int LastPackageNumber()
        {
            return Packages.Count - 1;
        }

        void IStoreRepository.ClearDB()
        {
            Packages.Clear();
        }

        #endregion

        #region Private methods



        #endregion
    }
}
