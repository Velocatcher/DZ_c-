// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
string stringNumber = Console.ReadLine();

int number;
bool isNumber = int.TryParse(stringNumber, out number);
Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
if (isNumber && stringNumber.Length == 3) // isNumber == True
  {
      Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
      Console.WriteLine($"{stringNumber} -> {stringNumber[1]}");
  }
  else
  {
      Console.WriteLine("В строчке присутсвуют буквы ИЛИ длина строки не 3 символа");
  }


//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// int number;

// bool isNumber = int.TryParse(stringNumber, out number);
// Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
// if (isNumber && stringNumber.Length >= 3) 
//  {
//      Console.WriteLine($"{stringNumber} -> {stringNumber[2]}");
//  }
//  else
//  {
//      Console.WriteLine($"{stringNumber} -> третьей цифры нет");
//  }



//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня недели: ");
// int numberDay = int.Parse(Console.ReadLine());

// // Console.WriteLine(numberDay);
// if (numberDay >=1 && numberDay <=5) 
//    {
//      Console.WriteLine($"{numberDay} -> нет");
//    }
// else if (numberDay >=6 && numberDay <=7)
//    {
//      Console.WriteLine($"{numberDay} -> да");
//    }  

// else    Console.WriteLine($"{numberDay}  -> такого дня недели не существует"); 