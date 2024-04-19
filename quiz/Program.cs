namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Quize Hoşgeldiniz!");
            Console.WriteLine("========================");
            Console.WriteLine(" ");
            Console.WriteLine("-Bu quizin içinde 10 adet soru bulunmaktadır.");
            Console.WriteLine("-Sorulara ister şık olarak isterseniz de cevabın kendisini yazarak yanıtlayabilirsiniz.");
            Console.WriteLine("-Doğru sayınızı oyun sonu ekranında görebilirsiniz.");
            Console.WriteLine("-Sorulara geçmek için herhangi bir tuşa basınız.");
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();

            string[] questions = ["Gökyüzü ne renktir?", "Türkiyenin başkenti neresidir?","Dünyanın en uzun nehrinin adı nedir?", "İnsan vücudundaki en büyük organ hangisidir?", "Hangi gezegenin adı Mars'tır?", "Karbonatlı içeceklerde bulunan gaz hangisidir?", "Türkiye'nin en yüksek dağı hangisidir?", "Bir futbol takımında kaç oyuncu bulunur?", "İnsanların yaşaması için gerekli olan gaz nedir?", "Deniz suyunun tuzluluğunu artıran mineral hangisidir?"];
            string[] answers = ["mavi", "ankara","amazon","cilt","mars","karbon dioksit","ağrı dağı","11","oksijen","sodyum"];
            string[] answersABCD = ["b", "a", "c", "a", "d", "b", "c", "b", "c", "b"];
            string[] options = ["Kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir|Antalya", "Nil|Mississippi|Amazon|Yangtze", "Cilt|Akciğer|Kalp|Karaciğer", "Venüs|Jüpiter|Neptün|Mars", "Hidrojen|Karbon dioksit|Azot|Oksijen", "Erciyes Dağı|Cilo Dağı|Ağrı Dağı|Tahtalı Dağı", "9|10|11|12","Oksijen|Azot|Karbon dioksit|Hidrojen","Kalsiyum|Sodyum|Potasyum|Magnezyum"];
            string[] abcd = ["A) ", "B) ", "C) ", "D) "];
            string line = "========================";
            string space = " ";

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(line);
                Console.WriteLine(space);
                Console.WriteLine((i + 1) + "-" + questions[i]);
                Console.WriteLine(space);
                string[] optionArray = options[i].Split('|');

                for (int j = 0; j < optionArray.Length; j++)
                {
                    Console.WriteLine((abcd[j] + optionArray[j]));
                }

                Console.WriteLine(space);
                Console.WriteLine(line);
                Console.WriteLine(space);
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();

                if (userInput == answers[i] || userInput == answersABCD[i])
                {
                    Console.WriteLine(line);
                    Console.WriteLine(space);
                    Console.WriteLine("Doğru Cevap!");
                    Console.WriteLine(space);
                    Console.WriteLine(line);
                    Console.WriteLine(space);
                    Console.WriteLine("Sıradaki soruya geçmek için herhangi bir tuşa tıklayın.");
                    Console.WriteLine(space);
                    Console.ReadLine();
                    Console.Clear();
                    score++;
                }
                else
                {
                    Console.WriteLine(line);
                    Console.WriteLine(space);
                    Console.WriteLine("Yanlış Cevap!");
                    Console.WriteLine(space);
                    Console.WriteLine(line);
                    Console.WriteLine(space);
                    Console.WriteLine("Doğru cevap '" + answers[i] + "' olucaktı.");
                    Console.WriteLine("Sıradaki soruya geçmek için herhangi bir tuşa tıklayın.");
                    Console.WriteLine(space);
                    Console.ReadLine();
                    Console.Clear   ();
                }

            }
            Console.WriteLine(line);
            Console.WriteLine (space);
            Console.WriteLine ("Tebrikler. Quizin sonuna geldiniz");
            Console.WriteLine(space);
            Console.WriteLine (line);
            Console.WriteLine (space);
            Console.WriteLine("Toplam " + questions.Length + " sorudan " + score + " tanesini doğru yaptınız.");
            Console.WriteLine("Toplam skorunuz : " + score + "/" + questions.Length);
        }
    }
}
 
