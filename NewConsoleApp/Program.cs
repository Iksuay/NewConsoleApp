//Задача 1
const string MyName = "Тамер";

Console.WriteLine("Привет, C#");
Console.WriteLine("Мне 25 лет");
Console.WriteLine($"Меня зовут {MyName}");
Console.WriteLine("\x23");
Console.WriteLine("\x40");

//Задача 2
string myName = "Тамер";
byte old = 25;
bool pit = true;
float foot = 42;

Console.WriteLine(" {0}\n {1}\n {3}\n {2} ", myName, old, foot, pit);

//Задача 3

Console.Write("Напишите ваше имя: ");

string name = Console.ReadLine();

Console.Write("Напишите ваш возраст: ");

byte age = (byte) int.Parse(Console.ReadLine());

Console.WriteLine("Ваше имя {0}, Ваш возраст {1}", name, age);

Console.Write("Какой ваш любимый день недели? ");

DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());

Console.WriteLine("Ваш любимый день недели {0}", day);
