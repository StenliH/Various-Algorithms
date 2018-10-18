using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousAlgorithms
{
    class CaesarCipher
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string MessageToEncrypt { get; set; }
        public int Key { get; set; }
        public string CryptedMessage { get; set; }

        public void EncryptWithCaesar()
        {
            char[] tempCrypted = new char[MessageToEncrypt.Length];
            char letter;
            int index = 0;

            for (int i = 0; i < MessageToEncrypt.Length; i++)
            {
                letter = MessageToEncrypt[i];

                if (Char.IsLetter(letter))
                {
                    if (Char.IsUpper(letter))
                    {
                        letter = Char.ToLower(letter);
                    }

                    index = alphabet.IndexOf(letter);

                    if ((index + Key) < alphabet.Length)
                    {
                        letter = alphabet[index + Key];
                    }
                    else
                    {
                        letter = alphabet[Key - (alphabet.Length - 1 - index) - 1];
                    }

                    if (Char.IsUpper(MessageToEncrypt[i]))
                    {
                        tempCrypted[i] = Char.ToUpper(letter);
                    }
                    else
                    {
                        tempCrypted[i] = letter;
                    }

                }
                else
                {
                    tempCrypted[i] = letter;
                }

            }

            CryptedMessage = String.Concat(tempCrypted);
        }

        public void GetMessage()
        {
            Console.WriteLine("Zadejte zprávu k zašifrování:");
            MessageToEncrypt = Console.ReadLine();
        }

        public void GetCryptingKey()
        {
            Console.WriteLine($"Zadejte šifrovací klíč (celé číslo v intervalu 1-{alphabet.Length-1}:");
            do
            {
                Key = int.Parse(Console.ReadLine());
            } while (!(Key > 0 && Key < 26));
        }

        public void PrintCryptedMessage()
        {
            Console.WriteLine("Zašifrovaný text:");
            Console.WriteLine(CryptedMessage);
        }
    }
}
