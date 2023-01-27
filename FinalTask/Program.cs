string[] array = new string[5] {"hello","12","мир", "123", "end"};
string[] ResArray = new string[array.Length];

System.Console.WriteLine("Вы ввели:");
for (int i = 0; i < array.Length; i++)
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