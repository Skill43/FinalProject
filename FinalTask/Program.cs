System.Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine());
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