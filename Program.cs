using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ComLib.Person p = new ComLib.Person();
            p.Sex = "男";
            p.Age = 25;
            p.Name = "张三";
            Console.WriteLine("哈哈搜狐佛说法");
            Console.ReadKey();

        }
    }
}
