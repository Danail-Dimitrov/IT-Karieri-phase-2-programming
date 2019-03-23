using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guide
{
    class Program
    {
        static void Main(string[] args)
        {
            new string(result.Reverse().ToAray()); -obrushta stringa result kato go pravi na array
int i = result.lenght; -i e ravno na duljinata na stringa i.ako v result ima 6 znaka i e ravno na 6
16tichna broina sistema:
            0 = 0x0
1 = 0x1
2 = 0x2
3 = 0x3
4 = 0x4
5 = 0x5
6 = 0x6
7 = 0x7
8 = 0x8
9 = 0x9
10 = 0xA
11 = 0xB
12 = 0xC
13 = 0xD
14 = 0xE
15 = 0xF
---------------------------------------------------------------------------------------------------------------------------------- -

 Convert.ToInt32(string, 16) - pravi string s hex chisla na dec chislo

string.format("{0:x}", decValue); -dec to hex

 \' – единична кавичка

-     \" – двойна кавичка

-     \\ – лява наклонена черта

-     \n – нов ред

-     \t – отместване(табулация)

- \uXXXX – символ, зададен с Unicode номера си, примерно \u03A7.
----------------------------------------------------------------------------------------------------------------------
object - bastina promenliva definira medodi koito vseki obekt ima moje da prieme vsqkakuv tip danni(primerche - kakto se otnasqt jivotno / kotka; kuche; delfin taka se otnasqt object/ int; char; string etc.
------------------------------------------------------------------------------------------------------------------------
ctl +.- help ot vs
-----------------------------------------------------------------------------------------------------------------------------
rechnici i lampda:
1.rechnici
imat kluch(vmesto index) i stoinost
1.1 klucha moje da e duma ili realno chislo
1.2 deklarirane
var phonebook = new Dictionary<string, string>();
            1.3 deklaraciq s nqkolko stoinosti
var phonebook = new Dictionary<string, List<string>>();
            1.4 Remove
phonebook.Remove["kluch"] - maha
1.5 pechatane
foreach (var pair in phonebook)
            {
                Console.Writeline("{0} -->  {1}", pay.Key, pair.Value);
            }
            1.6 osobenosti
            - izpolzvat hesh tablica +spisuk
             - pazqt kluchovete po reda na zapisvane
1.7 metodi

.Count - pazi broq na kluch,stoinost dvoikie
.Keys - davi ni vischki kluchove v kolekciq
  .Values - davi ni vischki stoinosti v kolekciq
    osnovnite:.Add;.Remove;.Clear
    .ContainsKey() - proverq dali klucha sushtestvuva(tova e burza operaciq)
      .ContainsValue() - proverqva dali stoinossta se sadurja(tova e bavna oberaciq)
.TryGetValue() - proverq dali klucha sushtestvuva i ako da pechata stoinostta mu
  .OrderBy(x => x.Key); -podrejba po azbuchen red;
.OrderByDescending(x => x.Key); -podrejba po azbuchen red na obratno;
            movies.Add("horrors", new List<string>());
            movies["horrors"].Add("Evil Dead");




            2.SortedDictionary < K,V >
              sortirat kluchovete v estestveniq im red
2.1 metodi
.Count - pazi broq na kluch,stoinost dvoikie
.Keys - davi ni vischki kluchove v kolekciq
  .Values - davi ni vischki stoinosti v kolekciq
    .ContainsKey() - proverq dali klucha sushtestvuva(tova e burza operaciq)
      .ContainsValue() - proverqva dali stoinossta se sadurja(tova e bavna oberaciq)
.TryGetValue() - proverq dali klucha sushtestvuva i ako da pechata stoinostta mu
  -------------------------------------------------------------------------------------------------------------------------------------------- -
  string

Преобразуване на string от и до char array:
string str = new String(new char[] { 's', 't', 'r' });
            char[] charArr = str.ToCharArray(); // ['s', 't', 'r']

            Case - insensitive сравняване на символни низовe
int result = string.Compare(str1, str2, true);
            // result == 0 if str1 equals str2
            // result < 0 if str1 is before str2
            // result > 0 if str1 is after str2

            str.Substring(int startIndex, int length)

str.Replace(match, replacement)– замества всички съвпадения
string cocktail = "Vodka + Martini + Cherry";
            string replaced = cocktail.Replace("+", "and");
            // Vodka and Martini and Cherry

            str.Remove(int index, int length) – изтрива част от низ
string price = "$ 1234567";
            string lowPrice = price.Remove(2, 3);
            // $ 4567

            str.Trim() – отрязва празно протранство в началото и края на низ
string s = "    example of white space    ";
            string clean = s.Trim();
            Console.WriteLine(clean); // example of white space

            str.Trim(params char[] chars)
string s = " \t\nHello!!! \n";
            string clean = s.Trim(' ', ',', '!', '\n', '\t');
            Console.WriteLine(clean); // Hello

            str.TrimStart() and str.TrimEnd()
string s = "   C#   ";
            string clean = s.TrimStart(); // clean = "C#   "
 =====================
StringBuilder sb = new StringBuilder(int capasity); -moje da mu se zadede nachalna duljina

sb.Append(str[i]); -dobavq
sb.Remove(5, 6); -maha ot index 5 na dqsno 6 elemnta
sb.Insert(5, " Peter"); -ot index 5 natam zapochva da vmukva stringa
builder.Replace("Peter", "George");
            --------------------------------------------------------------------
            На кратко: Въвеждане на масив от един ред:
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Обръща:
            Array.Reverse(arr);

            Сортира по дължина:
            Array.Sort(arr);

            Дава стойност 0 на последователни елементи:
            int[] arr = new int[] { 2, 4, -5, 1, 10 };

            Копира масива source в масива destination от позиция index 1:
source.CopyTo(destination, 1);

            source = 2 4 6 8 10 12 14 16
destination = 1 3 5 7 9 11 13 15 17
Array.Copy(source, 4, destination, 2, 3);
            1310121411131517

======================================================================
List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


Add(element) – добавя елемент към List<T>
AddRange()-dobavq mnogo ot list naprimer
Count – връща броя на елементите в List<T>
Remove(element) – премахва първото срещане на елемент (връща true / false)
RemoveAt(index) – премахва елемент по неговия индекс
Insert(index, element) – вмъква елемент на зададената позиция
Contains(element) – определя дали елемента се съдържа в списъка
Sort() – сортира във възходящ ред
Reverse() – обръща списъка наобратно














        }
    }
}
