double distance (int [] dotsA, int [] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2)+Math.Pow(dotsA[1]-dotsB[1], 2)+Math.Pow(dotsA[2]-dotsB[2], 2));
}

int [] dotsA = new int[3];
int [] dotsB = new int[3];

Console.WriteLine("Находим расстояние двух точек в 3D");
Console.WriteLine("Введите X(A):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y(A):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Z(A):");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X(B):");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y(B):");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Z(B):");
dotsB[2] = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Расстояние равно: {(Math.Round(distance(dotsA, dotsB),2))}");
