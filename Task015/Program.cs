
Console.WriteLine("Введите день недели");
int count = Convert.ToInt32(Console.ReadLine());
if(count>0 && count < 8)
{
    if(count != 6 && count != 7) Console.Write("Рабочий день");
    else{
    Console.WriteLine("Выходной");
    }

}
else 
{
    Console.Write("Bad");
}