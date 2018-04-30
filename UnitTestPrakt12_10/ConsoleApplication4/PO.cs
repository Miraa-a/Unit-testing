using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public abstract class PO : IComparable<PO>
    {
        public string Name;//Имя программы
        public string Company;//Компания, которая произвела продукт
        public DateTime DownloadDate;//Дата установки по
        public int TrialVersion;//Период бесплатного использования
        public int price;//Цена

        public PO(string name, string company, string date, int TrialVersion, int price)
        {
            this.Name = name;
            this.Company = company;
            this.DownloadDate = DateTime.Parse(date);//Используем класс для работы с датами как в практикуме 10
            this.TrialVersion = TrialVersion;
            this.price = price;
        }
        public abstract void Info(System.IO.StreamWriter fileOut);

        public int CompareTo(PO p)
        {
            //PO x = (PO)p;
            return this.Name.CompareTo(p.Name);
        }

       

        public virtual bool ItIsAWorks()
        {
            if (DownloadDate.AddDays(TrialVersion) >= DateTime.Now) return true;
            return false;
        }
        public string ProgramName
        {
            get { return Name; }
        }
    }    
}