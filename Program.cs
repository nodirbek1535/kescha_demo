using System;
// Basic. Ketma-ketlik boʻlimi uchun 1-amaliy vazifa
// Quyidagi faylda ko'rsatilgan topshiriqlarni bajaring, kodlarni github akkountingizga yuklang va hovolani yuboring:

// 1. Doira yuzi va aylana uzunligini hisoblash
// Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
// aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
// Input: radius=3
// Output: S=28.2743338823081, L=18.8495559215388
// --------------
// Input: radius=4.23
// Output: S=56.2122031914168, L=26.5778738493697
Console.WriteLine("1-topshiriq doira");
double r;
Console.WriteLine("radiusini kiriting:");
r=double.Parse(Console.ReadLine());
double L=2*Math.PI*r;
double S=Math.PI*r*r;
Console.WriteLine("doiraning yuzasi S="+S);
Console.WriteLine("doiraning uzunligi L="+L);
Console.WriteLine("1-topshiriq tugadi");
Console.WriteLine("------------------------------------------------------");
// 2. Valyuta konvertri
// Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
// e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
// Input: qiymat=2, kurs=12400 so’m
// Output: 24800 so’m
// ----------------
// Input: qiymat=7.6, kurs=12400 so’m
// Output: 94240 so’m
Console.WriteLine("2-topshiriq valyuta konventori");
double qiymat,kurs,output;
qiymat =2;
kurs=12400;
output=qiymat*kurs;
Console.WriteLine(output);
Console.WriteLine("2-topshiriq tugadi");
Console.WriteLine("------------------------------------------------------");
// 3. Yoshni hisoblash
// Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
// ifodalang. Kabisa yilini hisobga olmang
// Input: x=2004
// Output: 6935
// -----------------
// Input: x= 1996
// Output: 9855
Console.WriteLine("3-topshiriq yoshni hisoblash");
Console.Write("Tug'ilgan yilingizni kiriting: ");
int x = int.Parse(Console.ReadLine());
int currentYear = DateTime.Now.Year;
// Har yilda 365 kun borligini hisobga olib yoshni kunlarda hisoblash
int ageInDays = (currentYear -x) * 365;
Console.WriteLine($"Foydalanuvchi yoshi:{ageInDays} kunga teng");
Console.WriteLine("3-topshiriq tugadi");
Console.WriteLine("------------------------------------------------------");