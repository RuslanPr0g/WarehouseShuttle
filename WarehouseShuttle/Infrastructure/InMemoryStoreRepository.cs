using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class InMemoryStoreRepository : IStoreRepository
    {
        #region Tables

        private readonly FileAccess fileAccess = new FileAccess();

        public List<Package> Packages { get; set; }

        #endregion

        #region Implementation

        public Package GetPackageByNumber(int number)
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return Packages.FirstOrDefault(p => p.Number == number && p.SoftDeleted is false);
        }

        public Package GetPackageByPartOfPINAndOwner(string partOfPIN, string owner)
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return Packages.FirstOrDefault(p =>
            p.PackageInternationalNumber.EndsWith(partOfPIN) && p.Owner == owner && p.SoftDeleted is false);
        }

        public List<Package> GetActualPackages()
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return Packages.Where(p => p.SoftDeleted is false).ToList();
        }

        public List<Package> GetAllPackages()
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return Packages.ToList();
        }

        public int StorePackageToDB(Package package)
        {
            Packages.Add(package);
            fileAccess.ReWritePackagesToFile(Packages);
            return package.Number;
        }

        public void UnStorePackageInDB(int packageNumber)
        {
            var indexToUnStore = Packages.FindIndex(p => p.Number == packageNumber);
            if (Packages[indexToUnStore].EndDate >= DateTime.Now)
            {
                Packages[indexToUnStore].EndDate = DateTime.Now;
            }
            Packages[indexToUnStore].SoftDeleted = true;
            fileAccess.ReWritePackagesToFile(Packages);
        }

        public bool IsThereAPackageInStorageCell(int storageCellNumber)
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return !(Packages.FirstOrDefault
                (p => p.StorageCellNumber == storageCellNumber && p.SoftDeleted is false) is null);
        }

        public int LastPackageNumber()
        {
            Packages = fileAccess.ReadPackagesFromFile();
            return Packages.Count - 1;
        }

        public void ClearDB()
        {
            Packages.Clear();
            fileAccess.ReWritePackagesToFile(Packages);
        }

        #endregion
    }
}
