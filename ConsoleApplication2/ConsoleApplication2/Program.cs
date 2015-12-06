using System;

class UsingConstruct
{
    static void Main()
    {
        int i = 0;
        Calculator myCalculator = new Calculator();
        myCalculator.add();
        Console.ReadLine();
    }
}
class Calculator
{
    int firstNumber;
    int secondNumber;
    int reslut;
    public Calculator()
    {
        this.firstNumber = 100;
        this.secondNumber = 200;
    }
    public void add()
    {
        Console.Write("请输入第1个运算整数\n");
        int fisrtNumber = int.Parse(Console.ReadLine());
        if (fisrtNumber == 0)
        {
            fisrtNumber = this.firstNumber;
        }
        Console.Write("请输入第二个整数");
        int secondNumber = int.Parse(Console.ReadLine());
        if( secondNumber == 0)
        {
            secondNumber = this.secondNumber;
        }
        reslut = fisrtNumber + secondNumber;
        Console.WriteLine("运算结果: {0} +{1} = {2} ", fisrtNumber,secondNumber, reslut);
    }
}