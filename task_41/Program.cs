// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
Console.Clear();
System.Console.WriteLine("Введите числа через пробел");

int[] resultay = Console.ReadLine().Split().Select(int.Parse).ToArray();


int count(int[] mas)
{
    int i = 0;
    foreach (var item in mas)
    {
        if (item > 0) i++;
    }
    return i;
}
System.Console.WriteLine($"Введенные числа : {String.Join("|", resultay)} элеметов больше нуля- {count(resultay)}");