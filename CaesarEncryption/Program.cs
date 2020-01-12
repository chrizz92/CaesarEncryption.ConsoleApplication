using System;

namespace CaesarEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSentence = "";
            string loop = "j";
            int caesarNumber;
            Random rand = new Random();

            Console.WriteLine("Caesar-Verschlüsselung/Entschlüsselung");
            Console.WriteLine("======================================");
            do
            {
                caesarNumber = rand.Next(1, 26);
                Console.WriteLine("Zu verschlüsselnden Satz eingeben:");
                inputSentence = Console.ReadLine().ToUpper();
            }
            while (loop=="j");
            

        }
    }
}
