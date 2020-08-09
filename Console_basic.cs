using System;

namespace Sayhello
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestConsoleProperty();
            //Console.WriteLine("Hello World!");
            //TestConsoleInputAndOutput();
            DateTime date = DateTime.Now;
            Console.WriteLine($"当前日期为{date.Year}年{date.Month}月{date.Day}日");
            PoemShow();

      
        }
        static void TestConsoleProperty()
        {
            Console.Title = "Current Time:" + DateTime.Now;
            Console.WriteLine("\n展示控制台文本颜色属性的用法");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("此前景为绿色");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("蓝色前景，白色背景");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("黑色背景红色前景");
            //还原为白色的前景黑色的背景。
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
        }
        static void TestConsoleInputAndOutput()
        {
            Console.Write("请输入一个字符串：");
            String userinput = Console.ReadLine();
            Console.WriteLine("\0输入了{0},\"\\t\"共有{1}个字符\n", userinput, userinput.Length);
        }

        static void PoemShow()
        {
            String poem1 = "静夜思";
            String poem2 = "蝶恋花";
            Console.Write("请输入想看的古诗：");
            String userinput = Console.ReadLine();
            if(userinput==poem1)
                {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t\t静夜思\n");
                Console.ReadKey(true);
                Console.Beep();
                Console.WriteLine("\t 窗前明月光，疑是地上霜。");
                Console.ReadKey(true);
                Console.WriteLine("\t 举头望明月，低头思故乡。");
                }
            else if(userinput==poem2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\t\t\t蝶恋花\n");
                Console.ReadKey(true);
                Console.Beep();
                Console.WriteLine("\t 昨夜秋风来万里。月上屏帏，冷透人衣袂。有客抱衾愁不寐。那堪玉漏长如岁。");
                Console.ReadKey(true);
                Console.WriteLine("\t 羁舍留连归计未。梦断魂销，一枕相思泪。衣带渐宽无别意。新书报我添憔悴.");
            }
        }
    }
}
