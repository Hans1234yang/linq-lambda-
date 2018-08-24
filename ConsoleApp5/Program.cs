using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //左连接 
            var list1 = new Dictionary<string, string> { { "1", "张三" },{ "2","李四"},{"3","王五" }};
            var list2 = new Dictionary<string, string> { { "1", "张三" }, { "2", "李四" },{ "4", "杨六"}};

            var queryleft1 = (from l1 in list1
                          join l2 in list2
                          on l1.Key equals l2.Key into list
                          from l2 in list.DefaultIfEmpty()
                          select new { l1, l2 }
                        );

            var resutlleft1 = queryleft1.ToList();

            foreach(var res1 in resutlleft1)
            {
                Console.WriteLine(res1.l1);
                Console.WriteLine(res1.l2);
            }
            
        }
    }
}
