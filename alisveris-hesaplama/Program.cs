namespace alisveris_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alışveriş uygulamamıza hoşgeldiniz!");
            Console.WriteLine(" ");



            string[] products = ["Elma", "Armut", "Muz", "Portakal", "Üzüm", "Çilek", "Kiraz", "Ananas", "Karpuz", "Şeftali"];
            int[] prices = [ 10, 20, 40, 15, 25, 30, 12, 18, 35, 22];
            int[] stock = [ 5, 10, 20, 8, 15, 12, 6, 9, 18, 11 ];
            int shoppingCart = 0;
            int shoppingPrice = 0;
            string shoppingCartProducts = "";

            while (true)
            {
                Console.WriteLine("===================================");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine("- " + (products[i]) + " - " + (prices[i]) + " TL (Kalan Stok = " + (stock[i])+ ")" );
                }
                Console.WriteLine("===================================");
                Console.WriteLine(" ");
                Console.WriteLine("Almak istediğiniz ürünün ismini yazın : ");
                Console.WriteLine("Veya sepete geçmek için 't' yazın: ");
                Console.WriteLine(" ");
                string userInputProducts = Console.ReadLine().ToLower();
                Console.Clear();

                if (userInputProducts == "t")
                {
                    break;
                }

                bool found = false;
                for (int i = 0;i < products.Length; i++)
                {
                    if (userInputProducts == products[i].ToLower())
                    {
                        if (stock[i] > 0)

                            Console.WriteLine("Kaç adet " + products[i] + " almak istiyorsunuz?");
                            Console.WriteLine("===================================");
                            Console.WriteLine("Birim fiyatı = " + prices[i] + " TL ");
                            Console.WriteLine("Kalan stok = " + stock[i] + " Adet");
                            Console.WriteLine("===================================");
                            Console.WriteLine(" ");

                        int quantity = Convert.ToInt32(Console.ReadLine());
                            if (quantity <= stock[i])
                                
                                {
                                shoppingCart += quantity;
                                shoppingPrice += prices[i] * quantity;
                                stock[i] -= quantity;
                                shoppingCartProducts += quantity + " adet " + products[i] + ", ";
                                found = true;
                                Console.WriteLine(" ");
                                Console.WriteLine("===================================");
                                Console.WriteLine("İstediğiniz " + quantity +" adet "+ products[i] + " sepetinize eklendi");
                                Console.WriteLine("Devam etmek icin herhangi bir tuşa basın.");
                                Console.ReadLine();
                                Console.Clear();

                        }
                        else
                        {
                            Console.Clear   (); 
                            Console.WriteLine(products[i] + " stokta yok");
                        } break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Hatalı ürün girişi.");
                }

            }
            Console.WriteLine("===================================");
            Console.WriteLine("Sepetinizdeki ürün miktari : " + shoppingCart + " adet");
            Console.WriteLine("Sepetinizdeki ürünlerin listesi : " + shoppingCartProducts);
            Console.WriteLine("Toplam tutar: " + shoppingPrice + " TL");
            Console.WriteLine("===================================");
        }
    }
}
