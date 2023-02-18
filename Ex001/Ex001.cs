using static Metods;

public class Ex001
{
// реализовать перемешивание массива

// Программа:
public static void MixArrayEx()
{
int count = Input("Введите размер массива ");
int []array = CreateArray(count);
WriteArray(array);
FillArray(array);
WriteArray(array);
MixArray(array);
Console.WriteLine();
WriteArray(array);
}
}
