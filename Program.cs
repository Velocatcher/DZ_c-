// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// // Строчка - массив символов
// int number;
// // // // TryParse(строчка, out переменная для результата)
// bool isNumber = int.TryParse(stringNumber, out number);
// // // // Если isNumber == True, значит строчка stringNumber 
// // // // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// // // // Если в stringNumber только цифры, то 
// // // // в переменную number попадет само число; иначе - 0
// Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
// if (isNumber && stringNumber.Length >= 3) // isNumber == True
//  {
//      Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
//      Console.WriteLine($"{stringNumber} -> {stringNumber[1]}");
//  }
//  else
//  {
//      Console.WriteLine("В строчке присутсвуют буквы ИЛИ длина строки < 3 символов");
//  }


//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
// Строчка - массив символов
int number;
// // // TryParse(строчка, out переменная для результата)
bool isNumber = int.TryParse(stringNumber, out number);
// // // Если isNumber == True, значит строчка stringNumber 
// // // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// // // Если в stringNumber только цифры, то 
// // // в переменную number попадет само число; иначе - 0
Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
if (isNumber && stringNumber.Length >= 3) // isNumber == True
 {
     Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
     Console.WriteLine($"{stringNumber} -> {stringNumber[2]}");
 }
 else
 {
     Console.WriteLine($"{stringNumber} -> третьей цифры нет");
 }