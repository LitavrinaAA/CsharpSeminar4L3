int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
int numDigits(int num)
{
 int i;
    for (i = 0; num != 0; i++, num /= 10) ;
    return i;   

}

int num = InputNum("Input number: ");

System.Console.WriteLine(numDigits(num));