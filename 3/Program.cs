// Задача 3

// Задать строку:
string String = "ароза упаланалапу азора";

// Вызов функций:
bool Result = IsPalindrome(String);
PrintResult(Result);

// Функция проверки "да/нет":
bool IsPalindrome(string str)
{
    bool result = true;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            result = false;
        }
    }
    return result;
}

// Функция вывода ответа:
void PrintResult(bool result)
{
    bool res = IsPalindrome(String);
    if (res == true)
    {
        Console.Write("Строка является палиндромом");
    }
    else
    {
        Console.Write("Строка НЕ является палиндромом");
    }
}