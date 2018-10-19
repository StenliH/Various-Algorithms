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
        public string PlainMessage { get; set; }
        public int Key { get; set; }
        public string EncryptedMessage { get; set; }

        public void EncryptWithCaesar()
        {
            char[] tempCrypted = new char[PlainMessage.Length];
            char letter;
            int index = 0;

            for (int i = 0; i < PlainMessage.Length; i++)
            {
                letter = PlainMessage[i];

                if (Char.IsLetter(letter))
                {
                    if (Char.IsUpper(letter))
                    {
                        letter = Char.ToLower(letter);
                    }

                    index = alphabet.IndexOf(letter);

                    letter = alphabet[(alphabet.Length + index + Key) % alphabet.Length];

                    if (Char.IsUpper(PlainMessage[i]))
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

            EncryptedMessage = String.Concat(tempCrypted);
        }

        public void DecryptWithCaesar()
        {
            char[] tempDecrypted = new char[EncryptedMessage.Length];
            char letter;
            int index = 0;

            for (int i = 0; i < EncryptedMessage.Length; i++)
            {
                letter = EncryptedMessage[i];

                if (Char.IsLetter(letter))
                {
                    if (Char.IsUpper(letter))
                    {
                        letter = Char.ToLower(letter);
                    }

                    index = alphabet.IndexOf(letter);

                    letter = alphabet[(alphabet.Length + index - Key) % alphabet.Length];

                    if (Char.IsUpper(EncryptedMessage[i]))
                    {
                        tempDecrypted[i] = Char.ToUpper(letter);
                    }
                    else
                    {
                        tempDecrypted[i] = letter;
                    }

                }
                else
                {
                    tempDecrypted[i] = letter;
                }

            }

            PlainMessage = String.Concat(tempDecrypted);
        }


        public void GetMessageForEncrypting()
        {
            Console.WriteLine("Zadejte zprávu k zašifrování:");
            PlainMessage = Console.ReadLine();
        }

        public void GetMessageForDecrypting()
        {
            Console.WriteLine("Zadejte zprávu k rozšifrování:");
            EncryptedMessage = Console.ReadLine();
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
            Console.WriteLine(EncryptedMessage);
        }

        public void PrintDecryptedMessage()
        {
            Console.WriteLine("Rozšifrovaný text:");
            Console.WriteLine(PlainMessage);
        }

        public bool Menu()
        {
            //Console.Clear();
            Console.WriteLine("Co chcete udělat:");

            string option = Console.ReadLine();
            switch (option)
            {
                case "encrypt":
                    GetMessageForEncrypting();
                    GetCryptingKey();
                    EncryptWithCaesar();
                    PrintCryptedMessage();
                    return true;
                case "decrypt":
                    GetMessageForDecrypting();
                    GetCryptingKey();
                    DecryptWithCaesar();
                    PrintDecryptedMessage();
                    return true;
                default:
                    return false;
            }
        }
    }
}
