// 
// one more solution
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SumNum (int num){
    int sum = 0;
    for (int i = 1; i <= num; i++)
        sum += i;
        return sum;
    
}
int num = InputNum("Input num: ");
int sum = SumNum(num);
System.Console.WriteLine(sum);