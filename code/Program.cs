
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int s = Convert.ToInt32(Console.ReadLine());
string[] array = new string[s];
string[] arr = new string[s];

NewArray(array);
PrintNewArray(array);
Console.Write(" -> ");
TargetArray(s, array);

void NewArray(string[] array)
{
    for (int i = 0; i < s; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintNewArray(string[] array)
{
    for (int j = 0; j < s; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

void TargetArray(int s, string[] array)
{
    int count = 0;
    for (int k = 0; k < s; k++)
        if (array[k].Length <= 3)
        {
            arr[count] = array[k];
            Console.Write($"{arr[count]} ");
            count++;
        }
}
