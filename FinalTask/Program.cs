Console.Clear();
int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
int n = InputNumber("Введите количество элементов массива:");
string[] array = new string[n];
string[] ResArray = new string[array.Length];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0;i< n; i++)
{
   
   array[i]= Console.ReadLine();
}
System.Console.WriteLine();

System.Console.WriteLine("Вы ввели:");
for (int i = 0; i < n; i++)
{
        System.Console.Write("|"+ array[i]);
}
System.Console.WriteLine();
SecondArray(array, ResArray);
System.Console.WriteLine("Массив из строк, длинна которых <= 3 символа: ");
ResArr(ResArray);
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i =0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void ResArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("|"+ array[i]);
    }
}