// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше, либо равна трем символам.
// Певоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] str = { "Hello", "-2", "WOW", "minus", "Hi" };
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length > 3)
        {
            count += 1;
        }
}
string[] sec_str = new string[str.Length - count];
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        for (int j = 0; j < sec_str.Length; j++)
        {
            sec_str[j] = str[i];
            System.Console.Write(" " + sec_str[j]);
            break;
        }
    }
}
