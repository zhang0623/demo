using System;

using System.Collections.Generic;
using System.Text;
namespace Example_1
{
    class Welcome
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的姓名：");
            string strName = Console.ReadLine();
            Console.WriteLine("{0},你好！欢迎使用c#语言！", strName);
        }
    }
}