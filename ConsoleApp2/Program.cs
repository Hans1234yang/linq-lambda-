using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //涉及到 交集，并集的时候，用lambda表达式更好
        static void Main(string[] args)
        {
            var list = new List<string>() { "张三1", "张三2", "张三3", "张三0", "李四9", "张三3", "李四", "张三2", "李四" };

            var students2 = list
                         .Where((item, index) => item.Contains("张三"))
                         .Select((item, index) => new { item, index })
                         .Reverse()//反序
                         .ToList();

            foreach(var res in students2)
            {
                Console.WriteLine(res.item);
                Console.WriteLine(res.index);
            }
        }
    }
}
