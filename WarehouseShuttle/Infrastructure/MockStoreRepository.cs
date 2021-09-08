using System.Collections.Generic;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class MockStoreRepository : IStoreRepository
    {
        #region Tables

        private List<Package> Packages;

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
            throw new System.NotImplementedException();
        }

        public Package GetPackageByPINAndOwner(string PIN, string owner)
        {
            throw new System.NotImplementedException();
        }

        public List<Package> GetPackages()
        {
            throw new System.NotImplementedException();
        }

        public int StorePackageToDB(Package package)
        {
            throw new System.NotImplementedException();
        }

        public void UnStorePackageInDB(int packageNumber)
        {
            throw new System.NotImplementedException();
        }

        public bool IsThereAPackageInStorageCell(int storageCellNumber)
        {
            return false;
        }

        public int LastPackageNumber()
        {
            return Packages.Count - 1;
        }

        #endregion

        #region Private methods



        #endregion
    }
}
