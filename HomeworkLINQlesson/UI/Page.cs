using HomeworkLINQlesson.Data;
using HomeworkLINQlesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkLINQlesson.UI
{
    public class Page
    {
        public void Drow()
        {
            Console.WriteLine("Ноутбуки в Астане");
            Console.WriteLine("Сначало дешевле - 1");
            Console.WriteLine("Сначало дороже - 2");
            Console.WriteLine("По названию - 3");
           

            int.TryParse(Console.ReadLine(), out int sortNumber);
            using (var context = new ShopContext())
            {
                var perPage = 10;
                var currentPage = 1;
                var pagination = context.Notebooks
                    .Skip((currentPage - 1) * perPage)
                    .Take(perPage);

                IQueryable<Notebook> notebooks = null;
                switch (sortNumber)
                {
                    case 1:
                        notebooks = context.Notebooks.OrderBy(notebook => notebook.Price);
                        break;
                    case 2:
                        notebooks=context.Notebooks.OrderByDescending(notebook => notebook.Price);
                        break;
                    case 3:
                        notebooks=context.Notebooks.OrderBy(notebook => notebook.Model);
                        break;
                    default :
                        break;

                }
                var result = notebooks.ToList();
                foreach(var item in result)
                {
                    Console.WriteLine($"Модель {item.Model}\nЦена {item.Price}\nПроцессор {item.Processor}\nЧастота процессора " +
                        $"{item.CPU}\nПамять {item.MemoryCapacity}\n{item.StorageDevice}\nРасширение экрана" +
                        $"{item.ScreenResolution}\nОперационная система {item.OperatingSystem}\n");
                }
            }

            
        }
    }
}
