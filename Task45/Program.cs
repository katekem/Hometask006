// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования
Console.Clear();
int[] CreateRandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max+1); 
    }
    return arr;
}
int[] myArray = CreateRandomArray(5,0,10);
Console.WriteLine(String.Join(" ", myArray));
int[] myArrayCopy = new int[myArray.Length];
for (int i = 0; i < myArray.Length; i++)
{
    myArrayCopy[i] = myArray[i];
}
Console.WriteLine(String.Join(" ", myArrayCopy));
