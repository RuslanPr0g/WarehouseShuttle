using System.Collections.Generic;
using System.Linq;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly FileAccess fileAccess = new FileAccess();

        public List<Administrator> Users { get; set; }

        public void AddUser(Administrator user)
        {
            Users.Add(user);
            fileAccess.ReWriteUsersToFile(Users);
        }

        public List<Administrator> GetUsers()
        {
            Users = fileAccess.ReadUsersFromFile();
            return Users;
        }

        public int LastPackageNumber()
        {
            Users = fileAccess.ReadUsersFromFile();
            return Users.Count - 1;
        }

        public void ClearDB()
        {
            Users.Clear();
            fileAccess.ReWriteUsersToFile(Users);
        }
    }
}
