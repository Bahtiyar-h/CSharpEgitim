using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifreyi Doğru Girdiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreyi hatalı Girdiniz.");
            //    Console.WriteLine("Şifreyi hatalı Girdiniz.");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı veri");
            //}

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı sayı.");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların ortalaması: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (avarage > 85 & avarage <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}


            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " +  result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulamasıı

            //Console.WriteLine("****** CSharp Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine();

            //string menuitem;

            //Console.Write("Lütfen detayını görmek istediğiniz menü seçin: ");
            //menuitem = Console.ReadLine();

            //if (menuitem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //}

            //if (menuitem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("---------------Çorbalar---------------");
            //}

            //if (menuitem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margharitha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("---------------Pizzalar---------------");
            //}

            //if (menuitem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("---------------İçecekler---------------");
            //}

            //if (menuitem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("---------------Tatlılar---------------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result);
            //        break;
                
            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölüm: " + result);
            //        break;

            //    default:Console.Write("Hatalı veri girişi!");
            //        break;
            //}

            #endregion


            Console.Read();
        }
    }
}
