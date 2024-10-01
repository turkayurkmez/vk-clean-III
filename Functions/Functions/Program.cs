// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");

/*
 * Temiz fonksiyon kuralları:
 *  1. Birim zamanda sadece bir iş yapmalıdır. (Don't repeat yourself - DRY)
 *  2. Parametre sayısı ne kadar azsa o kadar temizdir.
 *  3. Fonksiyon gövdesi ne kadar az satırdan oluşursa o kadar iyi!
 */


string getRandomWordFromList(List<string> words)
{
    return "ağaç";
}

string convertToPuzzle(string word)
{
    return "****";
}

void showPuzzle(string word)
{
    Console.WriteLine(word);
}

string getLetterFromUser()
{
    return "a";
}

bool puzzleIsIncludeLetter(string selectedWord, string letter)
{
    return true;
}

string replacePuzzleWithLetter(string puzzledWord, string letter)
{
    return "a*a*";
}

string getSuggestion()
{
    return "ağaç";
}

bool compareWords(string selected, string suggested)=> selected == suggested;


/*
 *  1. Rastgele kelime listesinin içinden bir kelime seç.
 *  2. Seçtiğin kelimenin her bir harfini '*' işaretine çevir.
 *  3. Ekranda bulmacayı göster.
 *  4. Kullanıcıdan harf iste
 *  5. Harfin kelimede olup olmadığına bak
 *  6. Varsa; pozisyondaki * işaretini harfe çevir. Yoksa hakkı 1 azalt.
 *  7. Kelime tahmin etmesini iste.
 *  8. Kelime ile tahmin edilen aynıysa oyunu bitir.
 *     Değilse 4. adıma geri dön
 *  
 *    
 */

string selectedWord = getRandomWordFromList(new List<string>());
var puzzledWord = convertToPuzzle(selectedWord);
showPuzzle(puzzledWord);
var letter = getLetterFromUser ();
if (puzzleIsIncludeLetter(selectedWord, letter))
{
   puzzledWord =  replacePuzzleWithLetter(puzzledWord, letter);
   showPuzzle(puzzledWord);
}

var suggest = getSuggestion();
if (compareWords(selectedWord,suggest))
{
    Console.WriteLine("Oyun bitti");
}


ReportGenerator reportGenerator = new ReportGenerator("");
reportGenerator.CreateReport("başlık", true, true, new List<string>(), new List<string>());