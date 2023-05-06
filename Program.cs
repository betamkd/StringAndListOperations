using StringAndListOperations;
using StringAndListOperations.Interfaces;

GenerateEmailTemplates generateMarketingEmail = new GenerateEmailTemplates();
ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
WriteToTxtFile writeToTxtFile = new	WriteToTxtFile();
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


//Console.ForegroundColor = ConsoleColor.Cyan;
//string emailTemplate = readFromTxtFile.ReadFromFile();
//Console.WriteLine(emailTemplate);
//Console.ResetColor();
//Console.WriteLine("*******************************\n");
//int wordCount = counters.WordCount(emailTemplate);
//int letterCount = counters.LetterCount(emailTemplate);
//int lineCount = counters.LineCount(emailTemplate);
//int fullstopCount = counters.FullstopCount(emailTemplate);
//int spaceCount = counters.SpacesCount(emailTemplate);
//int questionsMarkCount = counters.QuestionMarkCount(emailTemplate);

//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine("Word count: " + wordCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("Letter count: " + letterCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("Line count: " + lineCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.DarkRed;
//Console.WriteLine("Fullstop count: " + fullstopCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine("Space count: " + spaceCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Questionmark count: " + questionsMarkCount);
//Console.WriteLine("*******************************\n");
//Console.ResetColor();









// ------------------------------LIST METHOD----------------------------------------------


// Add element to list
List<int> intList = new List<int>();
intList.Add(1);
intList.Add(2);
intList.Add(3);
intList.Add(4);
intList.Add(5);

//// Add multiple elements to list
List<int> intList2 = new List<int>();
intList2.AddRange(new int[] { 1, 2, 3 });
intList.AddRange(new int[] { 1, 2, 3 });

// Remove elements from a list by index
//intList.RemoveAt(5);

// Remove element from a list by value
//intList.Remove(1);

//Remove all elements that match a condition by element
//intList.RemoveAll(x => x == 1);


//Get the number of elements in a list
//List<int> intlist3 = new List<int> {1, 2, 3};
//int numberOfElements = intlist3.Count;

//if(numberOfElements == 0)
//{
//	Console.WriteLine("Listata e prazna");
//}
//else if (numberOfElements > 0)
//{
//	Console.WriteLine("Listata e polna");
//}

// Get the index of an element in list
//List<int> intList4 = new List<int> { 1, 2, 3 };
//int index = intList4.IndexOf(2);

// How to sort a list in ascending order.
//List<int> intList5 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList5.OrderByDescending (x => x);
//intList5.Sort();



// How to sort a list in descending order.
//List<int> intList6 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList6.Sort((a, b) => b.CompareTo(a));

//List<int> _intListTemp = new List<int>();

//foreach (var item in intList6)
//{
//	int _temp = 0;

//	if (item > _temp)
//	{
//		_temp = item;
//		_intListTemp.Add(item);
//	}
//}

//_intListTemp = intList;



//How to check if a list contains a specific element
//List<int> intList7 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<string> stringList7 = new List<string> { "John", "Doe", "Asssaaaa"};
//bool containsElement = intList7.Contains(3);
//bool containsElement2 = stringList7.Contains("Bla");

//int getTheIndex = intList7.IndexOf(3);

//if (containsElement2)
//{
//	int getTheIndex2 = stringList7.IndexOf("Bla");
//	string getItemFromList = stringList7[getTheIndex2];
//}

//int getTheIndex = intList7.IndexOf(3);



//How to clear all elements from a list
//List<int> intList8 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList8.Clear();


//How to create a new list that contains only even numbers from an existing list?
//List<int> intList8 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<int> evenNumbers = intList8.FindAll(x => x % 2 == 0);

//How to concatenate  two lists into a new list?
//List<int> intList9 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<int> intList10 = new List<int> { 11, 10, 12, 16 };
//List<int> concatenatedList = intList9.Concat(intList10).ToList();


//How to get the first element in a list?
//How to get the last element in a list?
//List<int> intList10 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//int firstElement = intList10.First();
//int lastElement = intList10.Last();



Console.WriteLine("");

writeToTxtFile.WriteToFile();