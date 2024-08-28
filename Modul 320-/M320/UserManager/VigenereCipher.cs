using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserManager
{
    public class VigenereCipher : ICipher
    {
        private readonly char[] alphabet = "abcdefghijklmnopqrstufwxyzäöüABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ÄÖÜ".ToCharArray();

        private readonly string keyword;

        private readonly char[][] matrix;

        public VigenereCipher(string keyword)
        {
            var key = keyword.Distinct().ToList();
            var x = alphabet.Length;
            var y = key.Count;
            var c = 0;
            this.matrix = new char[y][];
            for (var i = 0; i < x; i++)
            {
                if (key.Contains(alphabet[i]))
                {
                    this.matrix[c] = new char[x];
                    for (var j = 0; j < x; j++)
                    {
                        var index = (i + j) % x;
                        this.matrix[c][j] = alphabet[index];
                    }

                    c++;
                }
            }

            this.keyword = keyword;
        }

        public string Encrypt(string plaintext)
        {
            var ciphertext = string.Empty;
            plaintext = Regex.Replace(plaintext, @"\s+", string.Empty);
            for (var i = 0; i < plaintext.Length; i++)
            {
                for (var j = 0; j < this.keyword.Length; j++)
                {
                    if (this.matrix[j][0] == this.keyword[i % this.keyword.Length])
                    {
                        var charIndex = Array.IndexOf(this.alphabet, plaintext[i]);
                        ciphertext += this.matrix[j][charIndex];
                    }
                }
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            var plaintext = string.Empty;

            for (var i = 0; i < ciphertext.Length; i++)
            {
                for (var j = 0; j < this.keyword.Length; j++)
                {
                    if (this.matrix[j][0] == this.keyword[i % this.keyword.Length])
                    {
                        var charIndex = Array.IndexOf(this.matrix[j], ciphertext[i]);
                        plaintext += this.alphabet[charIndex];
                    }
                }
            }

            return plaintext;
        }
    }
}
