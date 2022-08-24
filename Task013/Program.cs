//Вывести третью цифру числа

//int count = 0;

Console.WriteLine("Введите число: ");
string qul = Console.ReadLine();

//определим разрядность числа
int count = qul.Length;
Console.WriteLine( "разрядность числа: "+count );

if(count<3) Console.WriteLine( " Третьей цифры нет! " );
else
{
Console.WriteLine( "Третья цифра: "+qul[2] );
}

