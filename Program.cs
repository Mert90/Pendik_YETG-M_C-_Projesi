namespace Öğrenci_Durum_Takibi_Programı_Konsol_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim, girilenYas, siraNumarasi = 0;
            string girilenIsim;
            int elemanSayisi = 9999;
            int kontrolSayaci = 1;
            string[] isimler = new String[elemanSayisi];
            int[] yaslar = new int[elemanSayisi];
            char devammi = 'e';
            while (devammi == 'e' || devammi == 'E')
            {
                Console.Clear();

                Console.Title = "Öğrenci bilgi ekleme görüntüleme Programı";
                
                Console.WriteLine("\n\n\t\tÖĞRENCİ BİLGİ EKLEME GÖRÜNTÜLEME PROGRAMI");

                
                Console.WriteLine("\n\n\t\tMENÜ");
                Console.WriteLine("\n\t\t1) Yeni Öğrenci Bilgisi Ekleme");
                Console.WriteLine("\n\t\t2) Kayıtlı Bilgileri Görüntüle");
                Console.Write("\n\n\t\tSeçiminizi yapınız(1/2) : ");

                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Write("\n\n\t\t{0} no'lu öğrencinin ismini giriniz :", siraNumarasi + 1);
                        isimler[siraNumarasi] = Console.ReadLine();
                        Console.Write("\n\t\t{0} no'lu öğrencinin yaşını giriniz :", siraNumarasi + 1); ;
                        yaslar[siraNumarasi] = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\t\tGirdiğiniz öğrenci bilgileri eklendi.");

                        siraNumarasi++;
                        break;
                    case 2:
                        
                        Console.WriteLine("\n\t\tKAYITLI BİLGİLER");
                        for (int x = 0; x < siraNumarasi; x++)
                        {
                            Console.WriteLine("\n\t\t{0}) Öğrenci ismi :{1}, Yaşı :{2}", x + 1, isimler[x], yaslar[x]);
                        }
                        
                        break;
                    default:
                        Console.WriteLine("\n\t\tHatalı seçim.");
                        break;
                }
                kontrolSayaci += 1;

                Console.Write("\n\n\t\tDevam etmek istiyor musunuz? (E/H) : ");
                devammi = char.Parse(Console.ReadLine());

            }
        }
    }
}
