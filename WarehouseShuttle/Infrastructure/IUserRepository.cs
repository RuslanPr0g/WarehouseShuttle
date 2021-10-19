using System.Collections.Generic;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a user to DB
        /// </summary>
        /// <param name="user">User to insert</param>
        void AddUser(User user);

        /// <summary>
        /// Gets all the users
        /// </summary>
        /// <returns>List of users</returns>
        List<User> GetUsers();

        /// <summary>
        /// Gets the last user's number
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int LastPackageNumber();

        /// <summary>
        /// Clears all the DB records
        /// </summary>
        void ClearDB();
    }
}
