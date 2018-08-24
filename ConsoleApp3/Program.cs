using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// 参数过多时，用linq表达式更好
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var list1 = new Dictionary<string, string> { { "1", "张三" }, { "2", "李四" }, { "3", "张三" }, { "4", "张三" } };
            var list2 = new Dictionary<string, string> { { "1", "张三" }, { "2", "李四" }, { "3", "李四" }, { "4", "张三" } };

            ///linq 表达式
            var query1 = from l1 in list1
                         join l2 in list2
                         on l1.Key equals l2.Key
                         select new { l1, l2 };

            var res1 = query1.ToList();
            foreach(var res in res1)
            {
                Console.WriteLine("list1是{0},{1}",res.l1.Key,res.l1.Value);
                Console.WriteLine("list2是{0},{1}",res.l2.Key,res.l2.Value);
            }

            //lambda 表达式 
            var query2 = list1.Join(list2, l1 => l1.Key, l2 => l2.Key, (l1, l2) => new { l1,l2});

            var result2 = query2.ToList();
            foreach(var res2 in result2)
            {
                Console.WriteLine("{0},{1}",res2.l1.Key,res2.l1.Value);
                Console.WriteLine("{0},{1}",res2.l2.Key,res2.l2.Value);
            }
        }
    }
}
