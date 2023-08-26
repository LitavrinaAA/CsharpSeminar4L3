// van more solution
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
int ReversNum(int i){
    int res = 0;
    while (i != 0)
    {
     res = res*10 + i%10; 
     i /= 10; 
    }
return res;
}
bool IsPolindrom(int num, int reversNum){
    return num == reversNum;
}
int num = InputNum("Input num: ");
int reversNum = ReversNum(num);
if (IsPolindrom(num,reversNum)) System.Console.WriteLine("It's Polindrome");
else System.Console.WriteLine("It's not Polindrome");