using StringAndListOperations;
using StringAndListOperations.Interfaces;

GenerateEmailTemplates generateMarketingEmail = new GenerateEmailTemplates();
ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
//Counters counters = new Counters();
ICounters counters = new Counters();


//string World = "";
//Console.WriteLine("Hello, \t \"  World  \" !");

//string nesto = " "; 

//bool isChecked = 3 != -1;

//bool uslov1 = true;
//bool uslov2 = false;
//bool uslov3 = true;


//			//false	   || //true
//if ((uslov1 && uslov2) || uslov3)
//{
//	Console.WriteLine("True");
//}
//else
//{
//	Console.WriteLine("False");
//}




//if (!isChecked)
//{
//	Console.WriteLine("True");
//}
//else
//{
//	Console.WriteLine("False");
//}

//Console.WriteLine("Enter a number: ");
//int num = int.Parse(Console.ReadLine());
////string result = number % 2 == 0 ? "Even" : "Odd";
//string result = num > 0 ? "Positiven broj" : num < 0 ? "Negativen broj" : "Nula";

//Console.WriteLine(result);
//if (num % 2 == 0)
//{
//	Console.WriteLine("Even");
//}
//else
//{
//	Console.WriteLine("Odd");
//}
//Console.WriteLine(result);


//Calculates the sum of two numbers using ternary operator
//Console.WriteLine("Enter first number: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number: ");
//int num2 = int.Parse(Console.ReadLine());

//int sum = num1 + num2;

//Console.WriteLine($"The sum is: {(sum >= 0 ? sum : 0)}");


//string myString = "Ima nesto vo ovoj string";
//var test = myString.Length;


//var result = myString.Length == 0 ? 
//	"Prazen string" 
//	: 
//	"Poln string";

//if (!String.IsNullOrEmpty(myString))
//{
//	Console.WriteLine("The string is empty.");
//}
//else
//{
//	Console.WriteLine("The string is not empty.");
//}

//Console.WriteLine(result);


//"IMA NESTO VO OVOJ STRING2"
//string myString2 = "Ima nesto vo ovoj string2";
//string myString3 = "Ima nesto vo ovOj strIng2";
//var test2 = myString.Length;

//var result2 = myString2.ToLower();
//var result3 = myString2.ToUpper();

//Console.WriteLine(result2);
//Console.WriteLine(result3;


//string myString4 = "Ima nesto vo ovoj string4";
//string myString5 = "vo";



//if (myString4.Contains(myString5))
//{
//	Console.WriteLine("Go sodrzi");
//}
//else
//{
//	Console.WriteLine("Ne go sodrzi");
//}

//string myString6 = "	odreden string 		          	";

//int dolzinaNaString = myString6.Length;

//var result = myString6.Trim();

//dolzinaNaString = result.Length;

//string myString7 = "odreden string 2";

//int dolzinaNaSubString = myString7.Length - 8; //gi odzema 8 pozicii i od odreden string 2 se dobiva string 2
//string result7 = myString7.Substring(8, dolzinaNaSubString);

//string result8 = myString7.Substring(0, myString.Length);

//Console.WriteLine(result7);


// *** Write a C# program to check if a string starts with a specific substring
// using the ".StartsWith()" method.
// Ovaa zadacha treba da dade Boolean, True False, ovde treba da se proveri dali postoi ili ne

//string myString = "hello World";
//string myString2 = "Hello";
//string myString3 = "World";
//string pesna = "NekojaPesna .mp3";
//string ekstenzija = ".mp3";

////Console.WriteLine((int)FootballEnum.Barcelona);

//bool startsWith = myString.StartsWith(myString2);
//bool endsWith = pesna.EndsWith(ekstenzija);


//Console.WriteLine(startsWith);

//string myString = "Hello World";
//string oldSubstring = "World";
//string newString = "Universe";

//string result = myString.Replace(oldSubstring, newString);

//Console.WriteLine(result);



//generateMarketingEmail.GenerateMarketingEmailTemplate();

//string string1 = "Hello";
//string string2 = "hello";


// .Equals
//Opcija 1
//bool result = string1 == string2;

//Opcija 2
//bool result = string1.Equals(string2, StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(result);

//.Insert()
//string string1 = "Hello World";
//string substring = "Nesto";
//int position = 6;

//string result = string1.Insert(position, substring);

//Console.WriteLine(result);

// .Compare();

//string firstString = "Hello";
//string secondString = "World";

//int result = string.Compare(firstString, secondString);

//if (result < 0)
//{
//	Console.WriteLine(firstString + " comes before " + secondString);
//}
//else if (result > 0)
//{
//	Console.WriteLine(secondString + " comes before " + firstString);
//} 
//else
//{
//	Console.WriteLine("The two string are equal");
//}

//.Remove()

//string firstString = "Hello World";

//int startIndex = 6;
//int count = 5;

//string result = firstString.Remove(startIndex, count);

//Console.Write(result);



// .Count()
//string firstString = "Hello World";
//char character = 'o';

//int count = 0;

//count = firstString.Count(c => c == character);

//Console.WriteLine(count);

// .Join()

//string[] words = { "Hello", "World", "Hello1", "Hello2" };
//string separator = "	";

//string result = String.Join(separator, words);

//Console.WriteLine(result);

//.IndexOf()
//string firststring = "Hello World";
//char character = 'o';
//int index = firststring.IndexOf(character);
//Console.WriteLine(index);
//int LastIndex = firststring.LastIndexOf(character);


Console.ForegroundColor = ConsoleColor.Cyan;
string emailTemplate = readFromTxtFile.ReadFromFile();
Console.WriteLine(emailTemplate);
Console.ResetColor();
Console.WriteLine("*******************************\n");
int wordCount = counters.WordCount(emailTemplate);
int letterCount = counters.LetterCount(emailTemplate);
int lineCount = counters.LineCount(emailTemplate);
int FullstopCount = counters.FullstopCount(emailTemplate);
int spaceCount = counters.SpacesCount(emailTemplate);
int questionsMarkCount = counters.QuestionMarkCount(emailTemplate);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Word count: " + wordCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Letter count: " + letterCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Line count: " + lineCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Fullstop count: " + FullstopCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Space count: " + spaceCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Questionmark count: " + questionMarkCount);
Console.WriteLine("*******************************\n");
Console.ResetColor();

