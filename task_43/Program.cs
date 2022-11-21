// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double[] crossPt(double k1, double k2, double b1, double b2)
{
    double[] result = new double[2];
    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * result[0] + b1;
    return result;
}
System.Console.Write(" введите коэфициент k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] answer = crossPt(k1, k2, b1, b2);
System.Console.WriteLine($"Точки пересечения прямых  Х = {answer[0]},  Y = {answer[1]}");
