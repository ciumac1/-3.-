//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Ввод чисел от пользователя
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

// Нахождение максимального числа
double maxNum = Math.Max(num1, Math.Max(num2, num3));

// Вывод результата
Console.WriteLine("Максимальное число: " + maxNum);