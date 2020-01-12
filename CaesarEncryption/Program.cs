using System;

namespace CaesarEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSentence = "";
            string outputSentence = "";
            string mode = "1";
            string loop = "j";
            char encryptedChar; 
            int caesarNumber;
            Random rand = new Random();

            Console.WriteLine("Caesar-Verschlüsselung/Entschlüsselung");
            Console.WriteLine("======================================");
            Console.Write("Bitte Modus auswählen< 1=Verschlüsselung / 2=Entschlüsselung >: ");
            mode = Console.ReadLine();
            if (mode == "1")
            {
                do
                {
                    outputSentence = "";
                    caesarNumber = rand.Next(1, 26);
                    Console.WriteLine("Zu verschlüsselnden Satz eingeben:");
                    inputSentence = Console.ReadLine().ToUpper();
                    for (int i = 0; i < inputSentence.Length; i++)
                    {
                        encryptedChar = inputSentence[i];

                        if (encryptedChar == ' ')
                        {
                            outputSentence += " ";
                        }
                        else
                        {
                            encryptedChar = (char)(encryptedChar + caesarNumber);
                            if (encryptedChar > 90)
                            {
                                encryptedChar = (char)(encryptedChar - 25);
                            }
                            outputSentence += encryptedChar;
                        }
                    }

                    Console.WriteLine("Der verschlüsselte Satz lautet: ");
                    Console.WriteLine(outputSentence);
                    Console.WriteLine();
                    Console.Write("Programm nochmal ausführen <j/n>? ");
                    loop = Console.ReadLine();
                }
                while (loop == "j");
            }
            else if (mode == "2")
            {
                do
                {
                    Console.WriteLine("Zu entschlüsselnden Satz eingeben:");
                    inputSentence = Console.ReadLine().ToUpper();
                    Console.WriteLine("Mögliche Ursprungssätze:");
                    for (int k = 1; k < 26; k++)
                    {
                        for (int j = 0; j < inputSentence.Length; j++)
                        {
                            encryptedChar = inputSentence[j];
                            if(encryptedChar==' ')
                            {

                            }
                            else
                            {
                                encryptedChar = (char)(encryptedChar - k);
                                if (encryptedChar < 65)
                                {
                                    encryptedChar = (char)(encryptedChar + 25);
                                }
                            }
                            Console.Write(encryptedChar);
                            
                        }
                        Console.WriteLine();
                    }
                    



                    Console.Write("Programm nochmal ausführen <j/n>? ");
                    loop = Console.ReadLine();
                }
                while (loop == "j");
            }
            else
            {
                Console.WriteLine("Modus unbekannt. Programm wird beendet.");
            }
            
            

        }
    }
}
