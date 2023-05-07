

//string[] fruit = { "apples", "bananas", "oranges" };

using System.Security.Cryptography.X509Certificates;

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArraysLenght = fruit.Length;

Console.WriteLine($"There are {fruitArraysLenght} in your arry.");

for ( int i = 0; i < fruitArraysLenght; i++ )
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}
foreach (string element in fruit)
{
    Console.WriteLine(element);
}