//While İle Yapılan Örnek

//Burada koşul en balta kontrol edildiğinden kullanıcı -5 girerse koşula uymadığından çalışmayacaktır.

int sayac = 0;

Console.Write("Lütfen bir sayı giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayac++;
}

Console.WriteLine("--------------------------------");

//Do-While İle Yapılan Örnek

//Burada koşul en sonda olduğu için kullanıcı -5 girse bile en az 1 kez çalıştırılır.

int i = 0;

Console.Write("Lütfen bir sayı giriniz: ");
int sinir = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    i++;

} while (i <= sinir);
