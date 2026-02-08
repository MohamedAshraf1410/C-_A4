#region Q1

//A-THIS CODE IS INIFICCENT BECAUSE THAT WEHEN WE CHANGE A STRING IT CREATES WHOLE NEW OBJECT SO IT IS NOT GOOD FOR THE PEFORMANCE AND ADD TON OF WORK TO THE GARBAGE COLLECTOR

//B
using System.Text;
using System.Diagnostics;

Stopwatch sw1 = Stopwatch.StartNew();
Stopwatch sw2 = Stopwatch.StartNew();
StringBuilder productList = new StringBuilder();

string productlist = "";
for (int i = 0; i <= 5000; i++)
{
    productlist += "proud" + i + ",";
}

sw1.Stop();
Console.WriteLine($"Strong Builder time: {sw1.ElapsedMilliseconds} ms");//45ms


for (int i = 0; i <= 5000; i++)
{
    productList.Append($"proud {i}, ");
}

string result = productList.ToString();
sw2.Stop();
Console.WriteLine($"Strong Builder time: {sw2.ElapsedMilliseconds} ms");//3ms
#endregion


#region Q2

int age = int.Parse(Console.ReadLine());
int day =int.Parse(Console.ReadLine());
bool student = Console.ReadLine() == "yes";
double price;

if (age < 5) price = 0;
else if (age <= 12) price = 30;
else if (age <= 59) price = 50;
else price = 25;
if (price > 0 && (day == 6 || day == 7))
price += 10;

if (price > 0 && student)
price *= 0.8;

Console.WriteLine(price);

#endregion

#region Q3
string fileExtension = ".pdf";
string fileType;

switch (fileExtension)
{
 case ".pdf":
 fileType = "PDF Document";
 break;

 case ".doc":
 case ".docx":
 fileType = "Word Document";
 break;

case ".xls":
case ".xlsx":
fileType = "Excel Spreadsheet";
break;

case ".jpg":
case ".png":
case ".gif":
fileType = "Image File";
break;

default:
fileType = "Unknown File Type";
break;
}
#endregion


#region Q3
int temperature = 35;

string weatherAdvice =
temperature < 0 ? "Freezing! Stay indoors." :
temperature < 15 ? "Cold. Wear a jacket." :
temperature < 25 ? "Pleasant weather." :
temperature < 35 ? "Warm. Stay hydrated." :
"Hot! Avoid sun exposure.";

//No It becomes hard to read with many conditions I will chose ternary  for simple and short conditions and if-else for multiple conditions or complex logic
#endregion

#region Q5
#endregion


#region Q6

int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

//  Failing scores 
Console.WriteLine("Failing scores:");
foreach (int s in scores)
 if (s < 50)
Console.WriteLine(s);

// First score above 90
Console.WriteLine("First score above 90:");
foreach (int s in scores)
{
 if (s > 90)
 {
Console.WriteLine(s);
break;}
}

// Class average excluding scores below 40
int sum = 0, count = 0;
foreach (int s in scores)
{
 if (s >= 40)
 {
 sum += s;
  count++;}
    
}
Console.WriteLine($"Class average: {sum / count}");

// (d) GRADE NUMBERS
int A = 0, B = 0, C = 0, D = 0, F = 0;

foreach (int s in scores)
{
if (s >= 90) A++;
else if (s >= 80) B++;
else if (s >= 70) C++;
else if (s >= 60) D++;
else F++;
}

Console.WriteLine("Grade counts:");
Console.WriteLine($"A: {A}");
Console.WriteLine($"B: {B}");
Console.WriteLine($"C: {C}");
Console.WriteLine($"D: {D}");
Console.WriteLine($"F: {F}");
    


#endregion
