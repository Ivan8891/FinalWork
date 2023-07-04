string[] GetArray ()
{
    Console.Write("Задайте длину массива: ");
	int n = Convert.ToInt32(Console.ReadLine());
	string[] arr = new string[n];
	Console.WriteLine("Введите значения для множества: ");
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{i + 1}: ");
		arr[i] = Console.ReadLine();
	}
    return arr;
}
string[] NewArray (string [] array)
{
	int count = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i].Length <= 3) count++;
	}
	string[] newArray = new string[count];
    int index = 0;
	for ( int i = 0; i < array.Length; i++)
	{
		if(array[i].Length <= 3)
		{
		    newArray[index] = array[i];
            index++;
		}
	}
    return newArray;
}
string[] array = GetArray();
string[] newArray = NewArray(array);
Console.WriteLine($"Ваш массив: [{String.Join(" ", array)}]");
Console.WriteLine($"Массив со значениями не превышающих 3 символов: [{String.Join(" ", newArray)}]");

