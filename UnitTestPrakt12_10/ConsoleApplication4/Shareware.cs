using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Shareware : PO
    {
        public Shareware(string name, string company, string date, int TrialVersion, int price)
    : base(name, company, date, TrialVersion, price)
        { }

        public override void Info(System.IO.StreamWriter fileOut)
        {
            fileOut.WriteLine("Имя продукта: " + Name + "\nПроизводитель: "
                                 + Company + "\nДата установки ПО: " + DownloadDate.ToShortDateString()
                                 + "\nПериод бесплатного использования: " + TrialVersion
                                 + "\nCтоимость продукта: " + price + "euro/месяц \n");
        }
        public override bool ItIsAWorks()
        {
            if (DownloadDate.AddDays(TrialVersion) >= DateTime.Now) return true;
            /*Если сумма добавления к дате 
            установки дней на которые рассчитана пробная версия 
            больше либо равна текущей дате, то продукт еще можно использовать, если нет, 
            то у продукта закончилась пробная версия*/
            return false;
        }
      
    }
}
