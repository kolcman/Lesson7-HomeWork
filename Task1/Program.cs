//  Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] letters2d = {
    {'a','b','c'},
    {'d','e','f'},
};

string result = "";

foreach (char letters in letters2d)
{
    result += letters; 
}
System.Console.Write(result);