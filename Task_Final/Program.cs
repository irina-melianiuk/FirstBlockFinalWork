// Задача.
// Написать программу, которая из имеющегося массива строк 
// формирует массив строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуетс пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] --> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] --> ["-2"]
// ["Russia", "Denmark", "Kazan"] --> []

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

string[] CreateArrayStr(int num)
{
  string[] arr = new string[num];
  for (int i = 0; i < arr.Length; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    string temp = Convert.ToString(Console.ReadLine());
    arr[i] = temp;
  }
  return arr;
}

void PrintArray(string[] arr)
{
  Console.WriteLine($"Введенный массив: ");
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write($"{arr[i]}, ");
  }
  Console.Write($"{arr[arr.Length - 1]}");
  Console.Write("]");
}



int number = Promt("Введите количество элементов в массиве: ");
if (number > 0)
{
  string[] array = CreateArrayStr(number);
  PrintArray(array);
}
 else Console.WriteLine($"Введите число больше нуля.");

