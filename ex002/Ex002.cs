using static Metods;
public class Ex002
{
  public static void Ex002_test()
  {
  Console.Clear();
  int[] array = CreateArray(Input("Ввыведите размер массива: "));
  WriteArray(array);
  Console.WriteLine();
  FillArray(array);
  WriteArray(array);
  Console.WriteLine();
  Enumepatian(array);
  }
}