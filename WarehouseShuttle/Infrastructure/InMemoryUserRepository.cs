using System.Collections.Generic;
using System.Linq;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly FileAccess fileAccess = new FileAccess();

        public List<User> Users { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user);
            fileAccess.ReWriteUsersToFile(Users);
        }

        public List<User> GetUsers()
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
