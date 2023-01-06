// // Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
// Console.WriteLine("Введи число: ");
// string number = Console.ReadLine();
// if (number.Length<3)
// Console.WriteLine("Число должно содержать не меннее трех знаков");
// if (number.Length>5)
// Console.WriteLine("Число должно содержать не более шести знаков");
// else
// Console.WriteLine(number [2]);

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
// Console.WriteLine("Введи число: ");
// int number =int.Parse(Console.ReadLine()!);
// if (number == 6 || number ==7)
// Console.WriteLine($"Для числа {number} соответствует выходной день недели");
// if (number == 1 || number ==2 || number == 3 || number ==4 || number == 5)
// Console.WriteLine($"Для числа {number} соответствует будний день недели");
// if (number<1 || number>7)  
// Console.WriteLine($"Некорректный ввод");

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
Console.WriteLine("Введи число: ");
int number =int.Parse(Console.ReadLine()!);
int result1 = (number/10);
int result2 = (result1%10);
if (number<100 || number>999)
Console.WriteLine($"Некорректный ввод");
else
Console.WriteLine($"Вторая цифра числа {number} есть {result2}");