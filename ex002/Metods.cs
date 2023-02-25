using System.Text;
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Заполнение массива

public static void FillArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
    NameArray[index] = Rundom(-500000, 500000);
    index++;
  }
}
// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 3.2 ввод данных рандомно

public static int Rundom (int min, int max)
{
  int result = 0;
  result = new Random().Next(min, max);
  return result;
}



//  Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}


//нахождение числа

public static int FindNumber (int []array, int numb)
{
  int index = 0;
  int summ = 0;
  while (index < array.Length)
  {
    if(numb == array[index])
    summ = summ + 1;
    index++;
  }
  return summ;
}

//проверка на повтор числа

public static int ProvNaPovtor(int []array, int numb)
{
  int index = 0;
  while (index < numb)
  {
    if(array[numb] == array[index])
    {
      return 1;
    }
    index++;
  }
  return 0;
}

//перебор массива со счетом колличества повторяющихся элементов

public static void Enumepatian (int[] array, string fileName)
{
  StringBuilder text = new();
  int index = 0;
  while (index < array.Length)
  { 
    if (ProvNaPovtor(array, index) == 0)
    {
    text.Append(array[index] + "  " + FindNumber(array, array[index])+"р" + "\n");
    }
    index++;
  }
  File.WriteAllText(fileName, text.ToString());
  Console.WriteLine("Запись в файл " + fileName + " успешно завершена.");
}

// Вывод массива в строку stringBuilder

public static void WriteArrayInStringBuilder (int []NameArray)
{
    StringBuilder text = new();
    int index = 0;
    while (index < NameArray.Length)
    {
      text.Append(NameArray[index] + " ");
      index++;
    }
  System.Console.WriteLine(text);
}

// запись массива в файл

public static void ArrayToFile(string fileName, int []NameArray)
{
  StringBuilder text = new();
  for(int i = 0; i < NameArray.Length; i++)
  {
    text.Append(NameArray[i] + " ");
  }
  File.WriteAllText(fileName, text.ToString());
  Console.WriteLine("Запись в файл " + fileName + " успешно завершена.");
}
}

 

 
