using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list=new List<string>() { "张三", "张三", "张三", "张三", "李四", "张三", "李四", "张三", "李四" };

            var student = list
                        .Where((item, index) => item == "张三" && index % 2 == 0)
                        .Select((item, index) => new { item, index });
            var result = student.ToList();
            foreach(var res in result)
            {
                Console.WriteLine("{0},{1}",res.index,res.item);
              
            }
            
        }
    }
}
