// // Каким образом человек, который только пошел учиться, должен это решить?
// // Какое это к черту обучение с нуля?

public class Task3
{
    public static void Main(string[] args)
    {
        string input = "шалаш";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine(isPalindrome ? "Да, но программа обучения у Вас ужас!" : "Нет, не рассказать про методы и просить их применить!");
    }
    public static bool IsPalindrome(string str)
    {
        string normalized = new
        string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return normalized.SequenceEqual(normalized.Reverse());
    }
}
