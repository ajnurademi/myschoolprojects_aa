using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
    public class User
    {
        public User(string username, string password, ICipher cipher)
        {
            this.Username = username;
            this.password = password;
            this.Cipher = cipher;
        }
        private string password;
        private ICipher Cipher { get; set; }
        public string Username { get; set; }
        public string PasswordEncrypted
        {
            get
            {
                // var cipher = new CaesarCipher(10);
                //var cipher = new VigenereCipher("White");

                return Cipher.Encrypt(this.password);
            }
        }
    }
}
