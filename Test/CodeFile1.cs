using System;
namespace CodeFile1;
class CodeFile1
{
static void Main(string[] args)
{
    short a;
        int b, x;
    double c;

            //初始化变量a
            a = 10;
    //读取键盘输入，并转换为整数
    Console.WriteLine("请输入一个数字：");
    b = Convert.ToInt32(Console.ReadLine());
    c = a + b;
    //输出
    Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
    Console.ReadLine();
}
} 
  
