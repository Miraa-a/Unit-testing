using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class FREE : PO
    {
       

        public FREE(string Name, string Company) : base(Name, Company, "2010.01.01", 0, 0)
        { }

        public override void Info(System.IO.StreamWriter fileOut)//выводим информацию о бесплатных программах
        {
            fileOut.WriteLine("Имя продукта: " + Name + "\nПроизводитель: "
                                 + Company + "\n");
        }
        public override bool ItIsAWorks()//Узнаем можно ли ее еще использовать (переодпределяем базовый метод)
        {
            return true;
        }
       

    }
}
