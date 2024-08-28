using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
    public abstract class Cipher
    {
        public abstract string Encrypt(string plaintext);
        public abstract string Decrypt(string cipherntext);
    }
}
