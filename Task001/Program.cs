//Вывести третью цифру числа


//Создадим метод для определения разрядности числа
int Bit(int nmb)
{
    int temp = nmb;
    int count = 0;
for (; temp > 0; count++)
{
    temp = temp / 10;
}
return count;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int cnt = 0;
cnt = Bit(number); // Вызов метода

Console.WriteLine("разрядность числа: " + cnt);
int index = 0;
int arg = 1;

if(cnt < 3)  Console.WriteLine( " Третьей цифры нет! " );
else
 {
     if( cnt != 3 )
     {
index = cnt - 3;
while( index > 0)
{
arg = arg * 10;
index -=1;
}
number = number / arg; //Убираем лишнии разряды
     }
number = number % 10; //выделяем 3-ю цифру

 Console.Write("Третья цифра: "+number);
 }