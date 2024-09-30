// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

var x = 5;
var i = 0;
var ii = 1;

var d = 256; //Bu değişken, müşterinin sisteme kayit olduğu günden bu yana geçen gün sayısıdır.

//1. Anlamlı isim kullan!
var daysSinceCustomerCreated = 180;
var musterininKaydınBuYanaGecenGunSayisi = 200;

//bool banuAlkan = false;
//2. Kısaltma kullanmamaya çalış!
var hpLaptopCount = 15; //Bilgisayar sayısı
                        //Health Point  
                        //Hit Point
                        //horse power
                        //3. Değişken adı, veri tipiyle uyumlu olmalı
bool isApproved = true;
var isSelected = false;
var hasAnAddress = true;

int intNumber = 45;
double taxRate = 0.15;

string word = "Bir kelime";

//4. Kompleks tiplerin isimleri, instance isimlerinde geçmeli.
DataTable customersDataTable = new DataTable();
Random randomNumberGenerator = new Random();

//5. Bir veritipinin nasıl isimlendirileceğine (özellikle kafa karışıklığı olduğunda) ortak karar verilmeli
var emails = new List<string>();
var emailList = new List<string>();


//6. Birbirlerine benzeyen sembollerden kaçın!
var o = 0;
var l = 1;
if (o == 1)
{
    o = l;
}


//7. Birleştirilebilen değişkenleri birleştir!

string password = "Pa$$W0rd1";

bool isIncludeLetter = true;
bool isIncludeNumber = true;
bool isIncludeSymbol = true;


bool isSecurePassword = isIncludeLetter && isIncludeNumber && isIncludeSymbol;


if (isSecurePassword)
{
    Console.WriteLine("Şifre kurallara uyuyor!");
}

if (x < 10 && ii >= 20 && i % 3 == 0)
{

}

bool isSmallThenTen = x < 10;
bool isLargeOrEquaThen20 = ii >= 20;,
bool isModulo3 = x % 3 == 0;

bool isMatchRule = isSmallThenTen && isLargeOrEquaThen20 && isModulo3;

if (isMatchRule)
{

}


List<int[]> cellsOnBoard = new List<int[]>();

List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnBoard)
    {
        if (cell[0] == (int)CellType.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }

    return flaggedCells;
}

public enum CellType
{
    Empty=1,
    Exploded = 2,
    Flagged = 4,
    Opened = 8,
   
};
