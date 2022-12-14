// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// Используем массивы, не коллекции.

string text = "Еду. Тихо. Слышны звоны "
            + "Под копытом на снегу,"
            + "Только серые вороны "
            + "Расшумелись на лугу."
            + "Заколдован невидимкой,"
            + "Дремлет лес под сказку сна,"
            + "Словно белою косынкой "
            + "Подвязалася сосна.";

char[] separators = new char[] { ' ', '.', ',' };

string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Подборка слов из текста с количеством символов до 3: ");
for(var i = 0; i < subs.Length; i++)
{
  if(subs[i].Length <= 3)
  {
  string[] newArr = new string[subs.Length];
  newArr[i] = subs[i];
  Console.Write($"{newArr[i]}" + ", ");
  }
}

