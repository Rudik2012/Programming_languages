
// ДОМАШНЕЕ ЗАДАНИЕ
// Задача №2Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max = " + Math.Max(a, b));


// Задача №4 Напишите программу, которая принимает
//  на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число: ");
int a_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c_2 = Convert.ToInt32(Console.ReadLine());
int max_1 = Math.Max(a_2, b_2);
int max = Math.Max(max_1, c_2);
Console.WriteLine("Max = {0}", max);

// Задача 6: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}


// Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все
//  чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N) {
    if (count % 2 == 0){
        Console.Write("{0},", count);
    }       
    count++;
}

