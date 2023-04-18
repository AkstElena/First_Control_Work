string [] array = {"5","2","3","7","1","4","6"};
Console.WriteLine($"Исходный массив строк:  [\"{string.Join("\", \"",array)}\"]");
int size = array.Length;
int newSize = new Random().Next(0, 4);
Console.WriteLine($"Количество элементов в уменьшенном массиве (от 0 до 3 включительно): {newSize}");

string [] SmallArray(string [] array)
{
  for (int j = 0; j < size-newSize; j++)
  {
    int indexDel=new Random().Next(0, array.Length);
    string [] newArray = new string [array.Length-1];
    for (int i = 0; i < indexDel; i++)
      newArray[i] = array[i];      
    for (int i = indexDel; i < array.Length-1; i++) 
      newArray[i] = array[i+1];     
    array = newArray;
  }
  return array;
}

Console.WriteLine($"Итоговый массив строк:  [\"{string.Join("\", \"",SmallArray(array))}\"]");
