static void Main(string[] args)
{
    const string MyName = "Tamer";

    Console.WriteLine(MyName);

    Console.WriteLine("Привет, C#");
    Console.WriteLine("Мне 25 лет");
    Console.WriteLine("Меня зовут Тамер");
    Console.WriteLine("\x23");
    Console.WriteLine("\x40");

    Console.ReadKey();
}

string myName = "Тамер";
byte old = 25;
bool pit = true;
float foot = 42;

Console.WriteLine(myName);
Console.WriteLine(old);
Console.WriteLine(pit);
Console.WriteLine(foot);

enum DaysOfWeek : byte
{
    Monday = 1,
    Tuesday = 2
}

enum Semaphore
{
    Red = 100,
    Yellow = 200,
    Green = 300
}