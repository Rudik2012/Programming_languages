// напишите программу которая выводит квадрат числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqrt = number * number;
Console.WriteLine(sqrt); 

// Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(sqrt);
Console.WriteLine();

// Вывод с импользованием $
Console.WriteLine($"Квадрат числа {number} равен = {sqrt}");

// Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен = {1}", number, sqrt);

// выводим с помощью билиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr,2);
Console.WriteLine("Квадрат числа {0} равен = {1}", sqr, sqr_2);