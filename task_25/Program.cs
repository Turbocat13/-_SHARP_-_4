// Задача 1: напишите цикл, который принимает а вход два числа (А и В) и возводит число А в 
// натуральную степень В.
// 3, 5 -> 243 (3^5)
// 2, 4 -> 16

int Prompt (string message)
{
 System.Console.Write (message);
 string readInput = System.Console.ReadLine();
 int result = int.Parse (readInput);
 return result;
}

int Power (int powerBase, int exponent)
{
 int power = 1;
 for (int i = 0; i < exponent; i++)
 {
  power *= powerBase;
 }
 return power;
}

bool ValidateExsponent (int exponent)
{
 if (exponent < 0)
 {
  System.Console.WriteLine ("Показатель не должен быть меньше нуля");
  return false;
 }
 return true;
}

int powerBase = Prompt ("Введите основание: ");
int exponent = Prompt ("Введите показатель: ");
if (ValidateExsponent (exponent))
{
  System.Console.WriteLine ($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}



