using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //排序复杂时，用linq语句会更方便


            //linq语句语法
            var list1 = new Dictionary<string, string> { { "1", "张三" }, { "2", "李四" }, { "3", "张三" }, { "4", "张三" } };
            var list2 = new Dictionary<string, string> { { "1", "张三" }, { "2", "李四" }, { "3", "李四" }, { "4", "张三" } };

            var query1 = from l1 in list1
                         join l2 in list2
                         on l1.Key equals l2.Key
                         orderby l1.Key, l2.Key descending
                         select new { l1, l2 };
            ///提交到数据库执行，并获取结果
            var result1 = query1.ToList();

            foreach(var res1 in result1)
            {
                Console.WriteLine("列表1{0}",res1.l1);
                Console.WriteLine("列表2{0}",res1.l2);
            }

            //lmabda语句表达
            var query2 = list1.Join(list2, l1 => l1.Key, l2 => l2.Key, (l1, l2) => new { l1, l2 })
                        .OrderBy(lll => lll.l1.Key)
                        .ThenByDescending(lll => lll.l2.Key)
                        .Select(t => new {t.l1,t.l2 });

            var resutl2 = query2.ToList();
            foreach(var res2 in resutl2)
            {
                Console.WriteLine(res2.l1);
                Console.WriteLine(res2.l2);
            }

        }
    }
}
