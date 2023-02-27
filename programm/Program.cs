// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первонаяальный массив можно ввести с клавиатуры, 
// либо задать на страте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["12345", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] ConsToString(string inPutCons)  // метод преобразует строку в массив строк
{
    string[] delimiterStrings = {" ", ", ", ", ,", ",", " ," , ".", ". ", ". .", " ."};
    string[] outMass = inPutCons.Split(delimiterStrings, System.StringSplitOptions.RemoveEmptyEntries);
    return outMass;
}

int HowManyThreeSymbols(string[] inString) // метод считает, сколько в массиве строк элементов из трех и менее символов
{
    int count = 0;
    for (int i = 0; i<inString.Length; i++)
    {
        if (inString[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}

string[] ThreeSymbMass(string[] inString, int len) // метод принимает массив и строк и количество элементов из трех символов и меньше, а возвращает массив из элементов из трех символов и меньше
{
    string[] threeMass = new string[len];
    int j=0;
    for (int i=0; i<inString.Length; i++)
    {
        if (inString[i].Length <= 3)
        {
            threeMass[j] = inString[i];
            j++;
        }
    }
    return threeMass;
}


Console.Clear();
Console.WriteLine("Введите символьные последовательности через запятую: ");
string inStringCons = Console.ReadLine();
string[] inStringMass = ConsToString(inStringCons); // преобразование строки в массив строк
Console.WriteLine($"[{String.Join(", ", inStringMass)}] массив string"); // вывод массива строк для наглядности
int threeSymb = HowManyThreeSymbols(inStringMass);  // подсчет количества элементов, длина которых меньше либо равна трех символов
Console.WriteLine(threeSymb); // вывод количества для наглядности
string[] threeSymbString = ThreeSymbMass(inStringMass, threeSymb); // создание нового массива строк с элементами из трех и менее символов
Console.WriteLine($"[{String.Join(", ", threeSymbString)}] выходной массив"); // вывод массива с элементами их трех и менее символов

