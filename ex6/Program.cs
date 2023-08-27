// 28 to accept number N, return multiple from 1 to N
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int FactorialN(int num){
    int mult = 1;
    for (int i = 2; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}
int num = InputNum("Input num: ");
System.Console.WriteLine(FactorialN(num));
