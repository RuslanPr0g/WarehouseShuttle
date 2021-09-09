using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseShuttle.Common;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class AuthHandler
    {
        private readonly IUserRepository _userRepository;

        public static string SUCCESS = "";
        private readonly string login = "LOGIN";
        private readonly string signup = "SIGNUP";
        private readonly string needAnAccount = "Need an account?";
        private readonly string alreadyHere = "Already here?";

        public AuthHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool RequiredSymbols(string s)
        {
            bool number = false;
            bool uppercase = false;
            bool lowercase = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]) == true)
                {
                    uppercase = true;
                }
                if (Char.IsLower(s[i]) == true)
                {
                    lowercase = true;
                }
                if (Char.IsDigit(s[i]) == true)
                {
                    number = true;
                }
            }

            return (uppercase == true && lowercase == true && number == true);
        }

        public bool AreForbiddenSymbols(string S)
        {
            foreach (char s in S)
            {
                if (ForbiddenSymbols.SignUP.Contains(s))
                {
                    return true;
                }
            }

            return false;
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private static bool VerityPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        public void AddUser(Administrator user)
        {
            user.Password = HashPassword(user.Password);
            _userRepository.AddUser(user);
        }

        public bool UserExists(Administrator user)
        {
            List<Administrator> users = _userRepository.GetUsers();

            return users.Exists(u => u.Username == user.Username && VerityPassword(user.Password, u.Password));
        }

        public string SignupRequirements(Administrator user, string passwordToConfirm)
        {
            List<Administrator> users = _userRepository.GetUsers();

            if (user.Username == string.Empty || user.Password == string.Empty)
            {
                return "Some fields are empty.";
            }

            if (user.Password != passwordToConfirm)
            {
                return ("Passwords have to coincide.");
            }

            if (RequiredSymbols(user.Password) == false)
            {
                return "You need to use at least one number, one lowercase letter, one uppercase letter.\nExample: Sl0n.";
            }

            if (AreForbiddenSymbols(user.Password) == true || AreForbiddenSymbols(user.Username) == true)
            {
                string ff = "";

                for (int i = 0; i < ForbiddenSymbols.SignUP.Length; i++)
                    ff += ForbiddenSymbols.SignUP[i];

                return "Fields cannot contain the following: " + ff;
            }

            if (user.Username.Length > 16 || user.Password.Length > 16)
            {
                return "Username and/or Password must be shorter than 16 letters.";
            }

            if (users.Exists(u => u.Username == user.Username))
            {
                return ("Student exists.");
            }

            if (user.Password == user.Username)
            {
                return ("Password and Username cannot coincide.");
            }

            return SUCCESS;
        }

        public string SignUp(Administrator user, string passwordConfirm)
        {
            string requirements = this.SignupRequirements(user, passwordConfirm);

            if (requirements != SUCCESS)
                return requirements;

            AddUser(user);

            return SUCCESS;
        }

        public string LogIn(Administrator user)
        {
            try
            {
                if (UserExists(user) == true)
                {
                    return SUCCESS;
                }
                else
                {
                    return "Username does not exist or password is incorrect.";
                }
            }
            catch
            {
                return ("Username does not exist or password is incorrect.");
            }
        }

        public string LoginText
        {
            get
            {
                return login;
            }
        }

        public string SignupText
        {
            get
            {

                return signup;
            }
        }

        public string NeedAccount
        {
            get
            {
                return needAnAccount;
            }
        }

        public string AccountExists
        {
            get
            {
                return alreadyHere;
            }
        }
    }

}
