using System;
class Program
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine("Podaj trzy liczby naturalne");
        if (!TryParseNumber("Pierwsza liczba: ", out a))
        {
            Console.WriteLine("Podano nieprawidłową liczbe");
            return;
        }
        if (!TryParseNumber("Druga liczba: ", out b))
        {
            Console.WriteLine("Podano nieprawidłową liczbe.");
            return;
        }
        if (!TryParseNumber("Trzecia liczba: ", out c))
        {
            Console.WriteLine("Podano nieprawidłową liczbe.");
            return;
        }
        int[] numbers = { a, b, c };
        Array.Sort(numbers);
        a = numbers[0]; b = numbers[1]; c = numbers[2];
        if (a * a + b * b == c * c)
        {
            Console.WriteLine($"liczby {a},{b},{c} tworzą trojki pitagorejskiej");
        }
        else
        {
            Console.WriteLine($"liczby {a},{b},{c} nie tworzą trojki pitagorejskiej");
        }
    }

    static bool TryParseNumber(string prompt, out int result)
    {
        result = 0;
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (int.TryParse(input, out result) && result > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


