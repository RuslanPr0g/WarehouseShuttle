using System.Collections.Generic;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public interface IStoreRepository
    {
        /// <summary>
        /// Stores a package in DataBase
        /// </summary>
        /// <param name="package">Package to store in DB</param>
        /// <returns>Number of inserted package</returns>
        int StorePackageToDB(Package package);

        /// <summary>
        /// UnStores a package in DataBase
        /// </summary>
        /// <param name="package">Package to unstore in DB</param>
        /// <returns>Number of unstored package</returns>
        void UnStorePackageInDB(int packageNumber);

        /// <summary>
        /// Clears all the DB records
        /// </summary>
        void ClearDB();

        /// <summary>
        /// Gets the packages which are not softly deleted
        /// </summary>
        /// <returns>List of <see cref="Package"/></returns>
        List<Package> GetActualPackages();

        /// <summary>
        /// Gets all the packages
        /// </summary>
        /// <returns>List of <see cref="Package"/></returns>
        List<Package> GetAllPackages();

        /// <summary>
        /// Gets the last package's number
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int LastPackageNumber();
        
        /// <summary>
        /// Gets a package by its number
        /// </summary>
        /// <param name="number">Number of package</param>
        /// <returns><see cref="Package"/></returns>
        Package GetPackageByNumber(int number);

        /// <summary>
        /// Gets a package by part of PIN (e.g last 4 digits) and owner
        /// </summary>
        /// <param name="partOfPIN">Package international number</param>
        /// <param name="owner">Owner of package</param>
        /// <returns><see cref="Package"/></returns>
        Package GetPackageByPartOfPINAndOwner(string partOfPIN, string owner);

        /// <summary>
        /// Is there a package in a storage cell
        /// </summary>
        /// <param name="storageCellNumber">Storage cell number</param>
        /// <returns><see cref="bool"/></returns>
        bool IsThereAPackageInStorageCell(int storageCellNumber);
    }
}
