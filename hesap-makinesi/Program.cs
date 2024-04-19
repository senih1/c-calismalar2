namespace hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "================================";
            string space = " ";

            Console.WriteLine(line);
            Console.WriteLine(space);
            Console.WriteLine("Hesap makinesine hoşgeldiniz");
            Console.WriteLine(space);
            Console.WriteLine(line);
            Console.WriteLine(space);
            Console.WriteLine("1- V1 Toplama ve Ortalama alma");
            Console.WriteLine(space);
            Console.WriteLine("2- V2 Tüm İşlemler");
            Console.WriteLine(space);
            Console.WriteLine("3- V3 Sürekli İşlemler");
            Console.WriteLine(space);
            string userV = Console.ReadLine();
            Console.Clear();




            if (userV == "1")
            {
                while (true)
                {
                    Console.WriteLine("Kaç sayı gireceksiniz?");
                    int numberCount = int.Parse(Console.ReadLine());

                    int total = 0;

                    for (int i = 0; i < numberCount; i++)
                    {
                        Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                        int inputNumber = int.Parse(Console.ReadLine());
                        total += inputNumber;

                    }

                    double average = (double)total / numberCount;
                    Console.WriteLine("Girilen sayıların toplamı: " + total);
                    Console.WriteLine("Girilen sayıların ortalaması: " + average);
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            else if (userV == "2")
            {
                while (true)
                {
                    string[] calculations = ["Toplama", "Çıkarma", "Bölme", "Çarpma"];

                    Console.WriteLine(line);
                    for (int i = 0; i < calculations.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + calculations[i]);
                    }
                    Console.WriteLine(line);
                    Console.WriteLine(space);

                    Console.WriteLine(space);
                    Console.WriteLine("Hangi işlemi yapicaksiniz");
                    Console.WriteLine(space);
                    string userCalculation = Console.ReadLine().ToLower();
                    Console.Clear();

                    if (userCalculation == "1")
                    {
                        while (true)
                        {

                            Console.WriteLine("Toplama İşlemi");
                            Console.WriteLine(space);
                            Console.WriteLine("Kaç sayı gireceksiniz?");
                            int numberCount = int.Parse(Console.ReadLine());
                            Console.Clear();
                            int total = 0;

                            for (int i = 0; i < numberCount; i++)
                            {
                                Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
                                int inputNumber = int.Parse(Console.ReadLine());
                                total += inputNumber;
                            }
                            Console.WriteLine("Girilen sayıların toplamı: " + total);
                            Console.WriteLine("Baska bir işlem yapmak için e yazın.");
                            string inputUser = Console.ReadLine();
                            if (inputUser == "e")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (userCalculation == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Çıkarma işlemi");
                            Console.WriteLine(space);
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Kaç sayı çıkaracaksınız?");
                            int numberCount = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("Lütfen sayıların çıkarılacağı sayıyı giriniz: ");
                            Console.WriteLine(space);
                            int total = int.Parse(Console.ReadLine());
                            Console.WriteLine(space);
                            Console.WriteLine(line);

                            for (int i = 0; i < numberCount; i++)
                            {
                                Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
                                int inputNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine(space);
                                total -= inputNumber;
                            }
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Girilen sayıların cikarimi : " + total);
                            Console.WriteLine("Baska bir işlem yapmak için E yazın.");
                            Console.WriteLine("Aynı işlemden devam etmek için Enter'a basın.");
                            string inputUser = Console.ReadLine().ToUpper();

                            if (inputUser == "e")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                                Console.ReadLine();
                            Console.Clear();
                        }

                    }
                    else if (userCalculation == "3")
                    {
                        while (true)
                        {
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Bölme işlemi");
                            Console.WriteLine(space);
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Kaç sayı böleceksiniz?");
                            int numberCount = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("Lütfen böleceğiniz sayıyı giriniz: ");
                            Console.WriteLine(space);
                            double total = double.Parse(Console.ReadLine());

                            for (int i = 0; i < numberCount; i++)
                            {
                                Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
                                double inputNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine(space);
                                if (inputNumber == 0)
                                {
                                    Console.WriteLine("Bir sayı sıfıra bölünemez. Lütfen farklı bir sayı girin.");
                                    continue;
                                }
                                total /= inputNumber;
                            }
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Girilen sayıların bölümü : " + total);
                            Console.WriteLine("Baska bir işlem yapmak için E yazın.");
                            Console.WriteLine("Aynı işlemden devam etmek için Enter'a basın.");
                            string inputUser = Console.ReadLine().ToUpper();

                            if (inputUser == "E")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                                Console.ReadLine();
                            Console.Clear();
                        }

                    }
                    else if (userCalculation == "4")
                    {
                        while (true)
                        {
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Çarpma işlemi");
                            Console.WriteLine(space);
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Kaç sayı çarpacaksınız?");
                            int numberCount = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("Lütfen çarpacağınız ilk sayıyı giriniz: ");
                            Console.WriteLine(space);
                            double total = double.Parse(Console.ReadLine());

                            for (int i = 0; i < numberCount; i++)
                            {
                                Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
                                double inputNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine(space);
                                total *= inputNumber;
                            }
                            Console.WriteLine(line);
                            Console.WriteLine(space);
                            Console.WriteLine("Girilen sayıların çarpımı : " + total);
                            Console.WriteLine("Baska bir işlem yapmak için E yazın.");
                            Console.WriteLine("Aynı işlemden devam etmek için Enter'a basın.");
                            string inputUser = Console.ReadLine().ToUpper();

                            if (inputUser == "E")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                                Console.ReadLine();
                            Console.Clear();
                        }
                    }


                }
            }

            else if (userV == "3")
            {
                double total = 0;
                bool firstNumberSet = false;

                while (true)
                {
                    double number;
                    string inputUser;

                    if (!firstNumberSet)
                    {
                        Console.WriteLine(space);
                        Console.WriteLine(line);
                        Console.WriteLine(space);
                        Console.WriteLine("İlk sayıyı giriniz: ");
                        Console.WriteLine(space);
                        Console.WriteLine(line);
                        Console.WriteLine(space);
                        inputUser = Console.ReadLine();
                        if (inputUser.ToLower() == "e")
                        {
                            break;
                        }
                        total = Convert.ToDouble(inputUser);
                        firstNumberSet = true;
                    }

                    Console.WriteLine(space);
                    Console.WriteLine("Bu sayıyla işlem yapmak için bir sayı yazınız veya çıkış yapmak için 'e' yazınız : ");
                    Console.WriteLine(space);
                    inputUser = Console.ReadLine();

                    if (inputUser.ToLower() == "e")
                    {
                        break;
                    }

                    number = Convert.ToDouble(inputUser);

                    Console.WriteLine(space);
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
                    Console.WriteLine(space);
                    Console.WriteLine("(Sayı olarak) ");
                    Console.WriteLine(space);
                    Console.WriteLine(line);
                    Console.WriteLine(space);
                    Console.WriteLine("1 - Toplama ");
                    Console.WriteLine("2 - Çıkarma");
                    Console.WriteLine("3 - Çarpma ");
                    Console.WriteLine("4 - Bölme ");
                    Console.WriteLine(space);
                    Console.WriteLine(line);

                    string inputUserChoice = Console.ReadLine();

                    if (inputUserChoice == "1")
                    {
                        total += number;
                    }
                    else if (inputUserChoice == "2")
                    {
                        total -= number;
                    }
                    else if (inputUserChoice == "3")
                    {
                        total *= number;
                    }
                    else if (inputUserChoice == "4")
                    {
                        total /= number;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim.");
                    }

                    Console.WriteLine(space);
                    Console.WriteLine("Sonuç: " + total);
                }
            }

            else Console.WriteLine("Hatalı giriş.");
        }
    }
}
