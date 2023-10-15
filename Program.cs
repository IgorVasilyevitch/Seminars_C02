Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.Readline());
if (number >= 100 && number <= 999);
{
   System.Console.WtiteLine(number / 10 % 10);
}
else
{
   System.Console.WriteLine("ОШИБКА! Вы ввели не трехзначное число ") ; 
}