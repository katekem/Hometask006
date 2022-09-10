// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num2 = num;

int size = 0;
while (num2 / 2 != 0)
{
    num2 /=2;
    size++;
}
size++;

int[] res = new int[size];
int i = 0;
while (num / 2 != 0)
{
    res[i] = num % 2;
    num = num / 2;
    i++;
}
res[i] = num;

for (int k = 0; k < size/2; k++)
{
    int temp = res[k];
    res[k] = res[size -1 -k];
    res[size -1 -k] = temp;
}

Console.WriteLine($"Это число в двоичном коде: {String.Join("",res)}");