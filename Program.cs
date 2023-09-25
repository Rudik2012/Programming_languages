// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 999 && number > 99){
    int a = number / 10 % 10;
    Console.WriteLine(a);
}
else {
    Console.WriteLine("Вы ввели неправильное число!");
}

/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    while (number > 999){
        number = number / 10;
    }
    int Third = number % 10;
    Console.WriteLine(Third);     
}

/* Задача 15: Напишите программу, которая принимает
на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day == 6 || Day == 7) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
} 



