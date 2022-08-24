//определим метод обработки трехзначного числа
int NumberTwo(int number)
{
int number1 = 0;
int number2 = 0;
number1 = number % 100;

//if(number1 == 0) Console.WriteLine("Number two = "+0);
if(number1 == 0) number2 = 0;

else
{
number2 = number1 /10;
}
return(number2);
}
Console.WriteLine("ВВедите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int num = NumberTwo(number);
Console.WriteLine("Number two: "+num);