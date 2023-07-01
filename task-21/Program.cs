/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

int[] pointA = new int[3];
int[] pointB = new int[3];

Console.WriteLine("Введите все три координаты точки А через запятую и пробел(-1, 2, 3):");
pointA = System.Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse);

Console.WriteLine("Введите все три координаты точки B через запятую и пробел (-1, 2, 3):");
pointB = System.Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse);


double sumPow = 0;
for (int i = 0; i < 3; i++) 
{
    sumPow = sumPow + Math.Pow((pointB[i] - pointA[i]), 2);
}

sumPow = Math.Round(Math.Sqrt(sumPow), 2);

Console.WriteLine(sumPow);