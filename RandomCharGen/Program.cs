// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


var random = new Random();

// method #1
var chars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";

int num = random.Next(0, chars.Length);

Console.WriteLine($"random char1 = {chars[num]}");

// method #2
char char2 = (char)random.Next(65, 90);

Console.WriteLine($"random char2 = {char2}");

Console.ReadLine();
