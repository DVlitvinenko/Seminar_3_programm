using static Metods;
public class Ex002
{
  public static void Ex002_test()
  {
  int[] array = CreateArray(Input("Ввыведите размер массива: "));
  WriteArray(array);
  FillArray(array);
  WriteArray(array);
  Console.WriteLine(" ");
  Enumepatian(array);
  }
}