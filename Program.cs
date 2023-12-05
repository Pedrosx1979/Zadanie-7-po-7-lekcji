// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Podaj pierwszą liczbę ...");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę...");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Podaj trzecią liczbę...");
int c = Int32.Parse(Console.ReadLine());*/

int a = 25;
int b = 63;
int c = 79;
int maximum = Math.Max(a, Math.Max(c, b)); // zwraca  maxymalne wartości dla liczb 

Console.WriteLine($" Liczba {maximum} jest najwieksza");
