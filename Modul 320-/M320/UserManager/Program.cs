namespace UserManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Inversion of Control: Die Abhängigkeit abgeändert damit man die Sachen im Programm ändert, aber muss nicht zwingend im Porgramm sein es sollte einfach nicht bei User sein 
            , also die Verschlüsseung sollte nicht beim User Intsaniziert 

            ABHÄNIGKEIT ELEMINIEREN (User & den verschiedenen Verschlüsselugnen) --> (User & Cipher)
             */

            // CaesarCipher cipher = new CaesarCipher(10);  
            VigenereCipher cipher = new VigenereCipher("White");
            User max = new User("max", "geheim", cipher);
            System.Console.WriteLine($"Encrypted Password of max is '{max.PasswordEncrypted}' " +
                                           $"(decrypted: '{cipher.Decrypt(max.PasswordEncrypted)}')");
        }
    }
}