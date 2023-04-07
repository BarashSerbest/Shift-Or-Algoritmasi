using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ShiftOrAlgoritmasi
{
    class Program
    {
        static void Main()
        {
            Console.Write("Aranacak kelimeyi girin: ");
            string kelime = Console.ReadLine();

            // Dosya yolu ve adını belirtme
            string dosya_yolu = @"alice_in_wonderland.txt"; // txt dosyasını Visual Studio'ya eklenecek, Çözüm Gezgininde " tam yolu kopyala " dedikten sonra bu kısımda tırnak içerisine yazılacak.

            if (File.Exists(dosya_yolu))
            {
                // Dosya okuma işlemi için StreamReader nesnesi oluşturma
                using (StreamReader sr = new StreamReader(dosya_yolu))
                {
                    int kelimeSayisi = 0;
                    string satir;

                    // Metin dosyasını satır satır okuma
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // Regex kullanarak aranan kelimeyi bulma
                        MatchCollection matches = Regex.Matches(satir, kelime);

                        // Eşleşme sayısını kelimeSayisi değişkeninde toplama
                        kelimeSayisi += matches.Count;
                    }

                    Console.WriteLine("{0} adet \"{1}\" kelime bulundu.", kelimeSayisi, kelime);
                }
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı.");
            }

            Console.ReadKey();
        }
    }
}
