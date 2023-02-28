// Задача 19/ Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
//12821 -> да
//32 -> да

// Console.WriteLine("Введите пятизначное число: ");
//string number = Console.ReadLine();
//string str = Convert.ToString(number);
//int lgt = str!.Length;
//if (str[0]==str[4] && str[1]==str[3])
//Console.WriteLine("Число палиндром  ");
//else
//Console.WriteLine("Число не палиндром");


//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int i;
int j;
double result;
int[] pointA = new int[3];
Console.WriteLine("Введите координаты x, y, z для точки А: ");
for (i = 0; i < pointA.Length; i++)
    pointA[i] = (int)Convert.ToDouble(Console.ReadLine());
int[] pointB = new int[3];
Console.WriteLine("Введите координаты x, y, z для точки B: ");
for (j = 0; j < pointA.Length; j++)
    pointB[j] = (int)Convert.ToDouble(Console.ReadLine());
result = (double)Math.Sqrt(Math.Pow((pointB[0] - pointA[0]), 2) + Math.Pow((pointB[1] - pointA[1]), 2) + Math.Pow((pointB[2] - pointA[2]), 2));
Console.WriteLine("Расстояние между точками составляет:  " + result);





//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
