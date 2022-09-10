

// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] res = new int[num];
res[0] = 0;
res[1] = 1;
for (int i = 2; i < res.Length; i++)
{
    res[i] = res[i-1] + res[i-2];
}
Console.WriteLine(String.Join(" ", res));
