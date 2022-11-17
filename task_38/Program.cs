//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
double[] FIllArray(int N)
{
    double[] mass = new double[N];
    for (int i = 0; i < N; i++)
    {
        mass[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return mass;
}
double diff(double[] mass)
{
    double res;
    int max = 0;
    int min = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > mass[max]) max = i;
        if (mass[i] < mass[min]) min = i;

    }
    res = mass[max] - mass[min];
    System.Console.WriteLine($"Наибольший элемент = {mass[max]}");
    System.Console.WriteLine($"Наименьший элемент = {mass[min]}");
    return res;
}
System.Console.Write(" Введите колличество чисел в массиве - ");
int N = Convert.ToInt32(Console.ReadLine());
double[] newMass = FIllArray(N);
System.Console.WriteLine("Массив:");
System.Console.WriteLine(String.Join("|", newMass));
System.Console.WriteLine($"Разница между ммаксимальным и минимальным элементом массива = {Math.Round(diff(newMass), 2)}");
