//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Ввод чисел от пользователя
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

// Сравнение чисел
if (num1 > num2)
    {
        Console.WriteLine($"{num1} больше {num2}");
            Console.WriteLine($"{num2} меньше {num1}");
        }
else if (num1 < num2)
        {
            Console.WriteLine($"{num2} больше {num1}");
            Console.WriteLine($"{num1} меньше {num2}");
            }
            
else {
            Console.WriteLine($"{num1} и {num2} равны");
        }