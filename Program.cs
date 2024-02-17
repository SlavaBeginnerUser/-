// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

// // Решение №1
// string[] initArray = {"Hello", "2", "world", ":-)"};

// for (int e = 0; e < initArray.Length; e++)
// {
// 	if (initArray[e].Length <= 3)
// 	{
// 		Console.Write($"{initArray[e]} ");
// 		Console.WriteLine();
// 	}
// }

// Решение №2
string[] initArray = { "1234", "1567", "-2", "computer science" };
Console.Write($"Заданный массив: ");
Console.WriteLine();
for (int e = 0; e < initArray.Length; e++)
{
		Console.Write($"{initArray[e]} ");
		Console.WriteLine();
}
int sizeOfResultArray = 0;
for (int i = 0; i < initArray.Length; i++)
{
		if (initArray[i].Length <= 3)
		{
		sizeOfResultArray++;
		}
}
string[] resultArray = new string[sizeOfResultArray];
int j = 0;
int h=0;
Console.Write($"Массив на выходе: ");
Console.WriteLine();
while (h < initArray.Length)
{
	if (initArray[h].Length <= 3)
	{
		resultArray[j] = initArray[h];
		Console.Write($"{resultArray[j]} ");
		Console.WriteLine();
		j++;
	}
	h++;
}
