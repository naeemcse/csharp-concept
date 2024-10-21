using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    class User
    {
        public string UserName {  get; set; }
        public string Password { get; set; }
        private readonly string id ;

        public string ID
        {
            get
            {
                return id;
            }
        }

        public User(string username , string password) {

            id = GenerateId();
            UserName = username;
            Password = password;
        }
        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                Console.WriteLine("Password is changed.");
            }
            else
            {
                Console.WriteLine("Old password is incorrect.");
            }

        }

        private void EncryptPassword()
        {
            // Encrypt the password
        }
        private string GenerateId()
        {
            return new Random(DateTime.Now.Microsecond).Next(300, 999).ToString();
        }

    }
}
