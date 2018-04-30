using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Commercial : PO
    {
        int period;
        public Commercial(string name, string company, string date, int TrialVersion, int price, int period)
            : base(name, company, date, 0, price)
        { this.period = period; }

        public override void Info(System.IO.StreamWriter fileOut)
        {
            fileOut.WriteLine("Имя продукта: " + Name + "\nПроизводитель: "
                                 + Company + "\nДата установки ПО: " + DownloadDate.ToShortDateString()
                                 + "\nСтоимость продукта: " + price + "euro/месяц  \nПериод использования: " + period + "\n");
        }
        public override bool ItIsAWorks()
        {
            if (DownloadDate.AddDays(period) >= DateTime.Now) return true;
            return false;
        }
       
    }
}
