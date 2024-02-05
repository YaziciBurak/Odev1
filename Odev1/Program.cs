//1 - Switch case ile müşteriden alınan sipariş
//numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

Console.Write("Ürünün sipariş numarasını giriniz : ");
int orderNum = Convert.ToInt32(Console.ReadLine());

string Product = "";

switch (orderNum)
{
    case 1:
        Product = "Telefon";
        break;
    case 2:
        Product = "Bilgisayar";
        break;
    case 3:
        Product = "Klavye";
        break;
    case 4:
        Product = "Fare";
        break;
    case 5:
        Product = "Kulaklık";
        break;
    default:
        Console.WriteLine("Geçersiz ürün numarası");
        return;
}

Console.WriteLine("Sipariş ettiğiniz ürün budur : " + Product);

// 2 - kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam alışveriş tutarını
//hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

Console.Write("Kaç adet ürün almak istiyorsunuz : ");
int productNo = Convert.ToInt32(Console.ReadLine());

double Total = 0;

for (int i = 0; i < productNo; i++)
{
    Console.Write("Ürünün fiyatını giriniz : ");
    double Price = Convert.ToDouble(Console.ReadLine());

    Total += Price;
}
Console.WriteLine("Alışverişinizin toplam tutarı bu kadar : " + Total);




//3 -- Do ve While döngüsü nedir? Bununla ilgili örnek yapınız.

// while
int myNumber = 0;
while (myNumber <= 40)
{
    Console.WriteLine("Benim sayım " + myNumber);
    myNumber++;
}


// DO -- WHILE
int myNumber2 = 20;
do
{
    Console.WriteLine("Büyükten küçüğe doğru sıralama : " + myNumber2);
    myNumber2--;
}
while (myNumber2 > 0);


//  4 -- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

Console.Write("Sayı giriniz : ");
int Num = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (int i = 1; i <= (Num / 2); i++)
{
    if (Num % i == 0)
        Sum = Sum + i;
}
if (Num == Sum)
{
    Console.WriteLine(Num + "  " + "Mükemmel bir sayıdır. ");
    return;
}
Console.WriteLine(Num + " " + "Mükemmel bir sayı değildir. ");

//   5 -- String metotlarını araştırınız.Her bir metot için örnek yapınız.

// str.Length
string str = "Deneme";
int Leng = str.Length;
Console.WriteLine("String ifademin uzunluğu : " + Leng);

//  index - lastIndex
string str1 = "Deneme yazısı";
int index = str1.IndexOf("ya");
int lastIndex = str1.LastIndexOf("ya");
Console.WriteLine("ilk 'ya' ifadesinin başlangıç indexi : " + index);
Console.WriteLine("son 'ya' ifadesinin  : " + lastIndex);

//   Substring
string str3 = "Deneme yazısı";
string altStr = str3.Substring(1, 7);
Console.WriteLine("Deneme yazısı'nın 1. dizesinden başlayıp 7. dizesinde biten sonuç : " + altStr);

//   replace
string str4 = "Deneme yazısı";
string newStr = str4.Replace("yazısı", "makalesi");
Console.WriteLine(newStr);

//   ToLower - ToUpper
string str5 = "Deneme yazısı";
string strLower = str5.ToLower();
string strUpper = str5.ToUpper();
Console.WriteLine("Deneme yazısı üzerinde ToLower methodunun kullanılmış hali -->> " + strLower);
Console.WriteLine("Deneme yazısı üzerinde ToUpper methodunun kullanılmış hali -->> " + strUpper);

//   Trim
string str6 = "     Deneme yazısı     ";
string strTrim = str6.Trim();
Console.WriteLine("'  Deneme yazısı  ' şeklinde boşluklarla yazılmış string ifadenin Trim methodu kullanılmışmamış hali -->> " + str6);
Console.WriteLine("'  Deneme yazısı  ' şeklinde boşluklarla yazılmış string ifadenin Trim methodu kullanılmış hali -->> " + strTrim);

//    split
string str7 = "Bu bir deneme yazısıdır";
string[] strsplit = str7.Split(' ');
Console.WriteLine("Metnimin normal hali : " + str7);
foreach (string spl in strsplit)
{
    Console.WriteLine("Metnimin split methodu kullanılmış hali : " + spl);
}

//  Concat
string str8 = "Deneme ";
string str9 = "Yazısı ";
string concatStr = string.Concat(str8 + " " + str9);
Console.WriteLine(concatStr);

//  StartsWith -- EndsWith:
string str10 = "Deneme yazısı";
bool strWith = str10.StartsWith("Dene");
bool strWith2 = str10.StartsWith("Ese");
bool enWith = str10.EndsWith("zısı");
bool enWith2 = str10.EndsWith("Yazı");
Console.WriteLine("StartsWith deneme 1 : " + strWith);
Console.WriteLine("StartsWith deneme 2 : " + strWith2);
Console.WriteLine("EndsWith deneme 1 : " + enWith);
Console.WriteLine("EndsWith deneme 2 : " + enWith2);

//  Contains
string str11 = "Deneme yazısı";
bool cont = str11.Contains("Deneme");
bool con2 = str11.Contains("Demene");
Console.WriteLine(cont);
Console.WriteLine(con2);

//  Compare
string str12 = "Deneme yazısı";
string str13 = "Deneme yazısı";
int compRes = string.Compare(str13, str12);
Console.WriteLine(compRes);
string str14 = "Deneme yazısı";
string str15 = "Deneme yazıs";
int compRes1 = string.Compare(str14, str15);
Console.WriteLine(compRes1);

//  Equals
string str16 = "Deneme yazısı";
string str17 = "Deneme yazısı";
bool eqStr = string.Equals(str16, str17);
Console.WriteLine(eqStr);
string str18 = "Deneme yazısıı";
string str19 = "Deneme yazısı";
bool eqStr2 = string.Equals(str18, str19);
Console.WriteLine(eqStr2);

//   ToUpperInvariant -- ToLowerInvariant
string str20 = "Deneme yazısı";
string str21 = "Deneme Yazısı";
string upperVariant = str20.ToUpperInvariant();
string lowerVariant = str20.ToLowerInvariant();
Console.WriteLine("String değerimin normal hali : " + str20);
Console.WriteLine("String değerimin ToUpperInvariant kullanılmış hali : " + upperVariant);
Console.WriteLine("String değerimin ToLowerInvariant kullanılmış hali : " + lowerVariant);



//6 -- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.
//ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

Console.Write(" Ürününüzün fiyatınız giriniz : ");
double price = Convert.ToDouble(Console.ReadLine());

if (price < 300)
{
    price += 50;
    Console.WriteLine(" Toplam ödemeniz gereken tutar : " + price);
    return;
}
else
{
    Console.WriteLine(" Toplam ödemeniz gereken tutar : " + price);
}

// 7 -- iki ürünün kullanıcı tarafından fiyatı girildiğinde
// toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

Console.Write("1. Ürününüzün fiyatını giriniz : ");
double price1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2. Ürününüzün fiyatını giriniz : ");
double price2 = Convert.ToDouble(Console.ReadLine());

double total = price1 + price2;

if (total >= 500)
{
    price2 -= price2 * 0.4;
    total = price1 + price2;
    Console.WriteLine("Toplam ödemeniz gereken tutar : " + total);
}
else
{
    Console.WriteLine("Toplam ödemeniz gereken tutar : " + total);
}

//   8 -- 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

int num1 = 1;
for (int i = 1; i < 200; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
        num1++;
    }
}
Console.WriteLine("3'e ve 5'e tam bölünebilen toplam sayı adedim : " + num1);