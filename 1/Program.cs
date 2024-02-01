// Задача 1

// Функция для преобразования 2d-массива символов в строку:
string GetStringFromChar(char[,] array)
{
    string str = "";
    foreach (char c in array)
    {
        str += c;
    }
    return str;
}

// Задать массив:
char[,] TestCharArr = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

// Запустить функцию:
string str = GetStringFromChar(TestCharArr);

// Вывод на консоль:
Console.Write(str);