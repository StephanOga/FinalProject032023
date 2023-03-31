string[] arrayMain = new string[4] { "Hello", "2", "world", ":-)" };
string[] secondArray = new string[arrayMain.Length];
void ReplaceElementsMainToSecondArray(string[] arrayMain, string[] secondArray)
{
  int count = 0;
  for (int i = 0; i < arrayMain.Length; i++)
  {
    if (arrayMain[i].Length <= 3)
    {
      secondArray[count] = arrayMain[i];
      count++;
    }
  }
}

void PrintMainAndSecondArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    {
      
      Console.Write(array[i]); 
    }
    Console.WriteLine();
  }
}
