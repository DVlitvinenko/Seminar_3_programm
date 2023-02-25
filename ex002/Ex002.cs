using static Metods;
public class Ex002
{
  public static void Ex002_test()
  {
  int[] array = CreateArray(Input("Ввыведите размер массива: "));
  FillArray(array);
  ArrayToFile("file1.txt", array);
  Enumepatian(array, "file2.txt");
  }
}