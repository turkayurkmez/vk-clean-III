// See https://aka.ms/new-console-template for more information
using LSP;

Console.WriteLine("Hello, World!");

/*
 *  Bir nesne kendisini türeten üst sınıfa dönüştüğünde; üst sınıfın davranışlarını değiştiremez.
 *  Elimizde Personel isimli bir base class ve Muhasebeci diye bir derived class olsunç
 *  Bir fonksiyon diyelim ki bir Personel alıyor. Siz bu fonksiyona Muhasebeci de gönderseniz başka bir mirasçı da, fonksiyonunuz aynı biçimde çalışmalı!
 *  
 *  Bir fonksiyon diyelim ki bir Personel döndürüyor.....  
 */

//Sorun yok:
Square square = new Square() { EdgeLength = 10};
Rectangle rectangle = new Rectangle() { Width=5, Height=3};

Console.WriteLine(square.GetArea());
Console.WriteLine(rectangle.GetArea());


var rect = new Geometry().GetRectangle(5);
var rect2 = new Geometry().GetRectangle(5,10);
//rect.Width = 3;
//rect.Height = 6;

Console.WriteLine($"kare: {rect.GetArea()}");
Console.WriteLine($"dörtgen: {rect2.GetArea()}");





