string? yesNo = "";
while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
  Console.Write("Желаете вводить строки вручную? (yes/no): ");
  yesNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[]  {};

if (yesNo.ToLower() == "yes") {
  int n = InputNumbers("Введите количество элементов массива: ");
  arrayOfStrings = new string[n];
  for (int i = 0; i < arrayOfStrings.Length; i++)
  {
    Console.Write($" Введите эллемент массива {i+1}: ");
    arrayOfStrings[i] = Console.ReadLine();
  }
}
else 
{
  arrayOfStrings = new string[]  {"Омск", "Уфа", "Москва", "Рим", "Милан", "Бар"};
}
