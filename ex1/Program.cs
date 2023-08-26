int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

bool IsFiveDigits(int num)
{
    return num > 9999 && num < 100000;
}

bool IsPolindrom(int i)
{
    int i1 = i % 10;
    int i2 = (i / 10) % 10;

    int i4 = (i / 1000) % 10;
    int i5 = (i / 10000) % 10;

    if (((i1 == i5) && (i2 == i4)))
    {
        return true;
    } else {
        return false;
    }

}
int numIsPol = InputNum("Input number:");
bool fiveDigits = IsFiveDigits (numIsPol);
if ( !fiveDigits) 
    Console.Write("It's not five-digit");
else {
    if (IsPolindrom(numIsPol)) Console.Write("It's Polindrom");
    else Console.Write("It's not Polindrom");
}