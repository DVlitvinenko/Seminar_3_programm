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
    NameArray[index] = Input("Введите число номер " + index + ":");
    index++;
  }
}
// 3. Ввод данный

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}

// 4. перемешивание массива

public static void MixArray (int[] NameArray)
{
  int index = 0;
  int temp = 0;
  int MixIndex = 0;
  int length = NameArray.Length;
  while (index < length-index)
  {
    MixIndex = new Random().Next(index+1, length);
    temp = NameArray[index];
    NameArray[index] = NameArray[MixIndex];
    NameArray[MixIndex] = temp;
    index++;
  }
}

// 5. Вывод массива

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
}


