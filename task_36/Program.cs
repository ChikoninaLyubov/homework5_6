//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
int[] FIllArray(int N)
{
    int[] mass = new int[N];
    for (int i = 0; i < N; i++)
    {
        mass[i]= new Random().Next(1,100);       
    }
    return mass;
}
int evenSum(int[] mass)
{
    int sum = 0;
    foreach (var item in mass)
    {
       if (Array.IndexOf(mass, item)%2 >0)
       {
            sum += item;
       }
    }
    return sum;
}
System.Console.Write("Введите колличество чисел в массиве - ");
int N = Convert.ToInt32(Console.ReadLine());
int[] newMass = FIllArray(N);
System.Console.WriteLine("Массив:");
System.Console.WriteLine(String.Join("|", newMass));
System.Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях = {evenSum(newMass)}");