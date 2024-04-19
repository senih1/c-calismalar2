using System;

namespace tas_kagit_makas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taş,Kağıt & Makas Oyununa Hoşgeldiniz!");
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın.");
            Console.ReadLine();
            Console.Clear();

            int userScore = 0;
            int pcScore = 0;

            while (true)
            {
                Console.WriteLine("Taş,Kağıt & Makas ");
                string userInput = Console.ReadLine().ToLower();

                Random pc = new Random();
                string[] answers = ["taş", "kağıt", "makas"];
                int randomIndex = pc.Next(answers.Length);
                string pcInput = answers[randomIndex];

                string winner = "";
                if (userInput == pcInput)
                {
                    winner = "Berabere";
                }
                else if (userInput == "taş" && pcInput == "makas")
                {
                    winner = "Kullanıcı";
                    userScore++;
                }
                else if (userInput == "makas" && pcInput == "kağıt")
                {
                    winner = "Kullanıcı";
                    userScore++;
                }
                else if (userInput == "kağıt" && pcInput == "taş")
                {
                    winner = "Kullanıcı";
                    userScore++;
                }
                else if (pcInput == "taş" && userInput == "makas")
                {
                    winner = "Bilgisayar";
                    pcScore++;
                }
                else if (pcInput == "kağıt" && userInput == "taş")
                {
                    winner = "Bilgisayar";
                    pcScore++;
                }
                else if (pcInput == "makas" && userInput == "kağıt")
                {
                    winner = "Bilgisayar";
                    pcScore++;
                }
                else if (userInput == "Çıkış")
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("Kazanan : " + winner);
                Console.WriteLine("============================");
                Console.WriteLine("Kullanıcı Hamlesi : " + userInput);
                Console.WriteLine("Bilgisayar Hamlesi : " + pcInput);
                Console.WriteLine ("============================");
                Console.WriteLine("Kullanıcı : " + userScore);
                Console.WriteLine("Bilgisayar : " + pcScore);
                Console.WriteLine(" ");
                Console.WriteLine("Devam etmek için bir tuşa basin.");
                Console.WriteLine("Oyunu sonlandırmak için 'Çıkış' yazın.");
                Console.WriteLine(" ");

                string exit = Console.ReadLine();


                if (exit == "Çıkış")
                {
                    break ;
                }
                else

                Console.Clear ();

            }

            Console.Clear();
            Console.WriteLine("Oyundan çıkış yaptınız.");
            Console.WriteLine("============================");
            if (userScore > pcScore)
            {
                Console.WriteLine("Kazanan: Kullanıcı");
            }
            else if (pcScore > userScore)
            {
                Console.WriteLine("Kazanan: Bilgisayar");
            }
            else
            {
                Console.WriteLine("Sonuç Berabere!");
            }
            Console.WriteLine("============================");
            Console.WriteLine(" ");
            Console.WriteLine("Kullanici : " + userScore);
            Console.WriteLine("Bilgisayar : " + pcScore);
            Console.WriteLine(" ");
            Console.ReadLine ();
        }
    }
}
