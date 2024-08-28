using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
    public interface ICipher   // Nicht internal, weil wenn ein Teil public ist dann werden sie nicht übergeben --> alos alles public 
    {
        string Encrypt(string plaintext);
        string Decrypt(string ciphertext);
    }
}
