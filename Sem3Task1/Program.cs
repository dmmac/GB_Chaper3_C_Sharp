using System;
public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      bool result = false;

      char[] chars = number.ToString().ToCharArray();

      if (chars.Length == 5) 
      {
        result = ((chars[0] == chars[4]) && (chars[1] == chars[3]));
      }  
      else 
      {
        Console.WriteLine("Число не пятизначное");
      }

      return result;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64545;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
