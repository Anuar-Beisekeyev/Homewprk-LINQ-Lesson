using HomeworkLINQlesson.Data;
using HomeworkLINQlesson.UI;
using System;

namespace HomeworkLINQlesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(var context = new ShopContext())
            //{                
            //    context.SaveChanges();
            //}
            var menu = new Page();
            menu.Drow();
        }
    }
}
