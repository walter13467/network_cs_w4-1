using network_cs_w4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0,i = 0;

            Random randomNum = new Random();
            randomNum.Next(0, 100);
            int currentNum = randomNum.Next(0, 100);

            Console.WriteLine(currentNum);
            Console.WriteLine("請輸入0~100的數字");
            while(ans == currentNum)
            {
                
                ans = Convert.ToInt32(Console.ReadLine());
                i++;
                if (i >= 5)
                {
                    break;
                }
                Console.WriteLine("答錯了 還有"+(5-i)+"次機會");
            }
            

        }
    }
}