//принимает число и в нем количество цифр
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int numDigits(int num){
    int count = 0;
    while(num != 0) {
        num = num/10;
        //System.Console.WriteLine(num);
        count++;
    }
    return count;
}
int i = InputNum("Input num: ");
System.Console.WriteLine(numDigits(i));
//System.Console.WriteLine(i);