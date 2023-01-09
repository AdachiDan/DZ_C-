Console.Clear();
Console.WriteLine("Таблица кубов чисел");

Console.WriteLine("Введите число: ");
string writeN = Console.ReadLine()!;
int N = Convert.ToInt32(writeN);

int[] GetKubeTable(int N)
{
    int[] KubeArray = new int[N];

    for (int i = 0; i < N; i++)
    {
        KubeArray[i] = (i + 1) * (i + 1) * (i + 1);
    }

    return KubeArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{number} ^ 3 = {Array[i]}");
        number++;
    }
}

int [] KubeTable = GetKubeTable(N);
PrintTable(KubeTable);
