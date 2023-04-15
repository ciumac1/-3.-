//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Ввод числа от пользователя
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Проверка на четность
if (num % 2 == 0) {
        Console.WriteLine($"{num} - четное число");
        }
else {
            Console.WriteLine($"{num} - нечетное число");
        }