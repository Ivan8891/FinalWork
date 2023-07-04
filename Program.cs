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


