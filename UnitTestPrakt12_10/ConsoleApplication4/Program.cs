using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{ 

class Program
    {
       
    static void Main(string[] args)
        {
            //PO[] software = new PO[]{new FREE ("Blender", "blender.org"),
            //                new Shareware("EXCEL", "Microsoft", "15.02.2008", 50, 100),
            //                new FREE("Gimp", "GNOME Foundation"),
            //                new Shareware("3DS MAX", " Autodesk Inc.", "11.02.2018", 30, 75),
            //                new Commercial("Adobe Photoshop", "Adobe Systems Software Ireland Ltd.", "16.10.2012", 50, 28, 3650),
            //                };
            StreamReader fileIn = new StreamReader("input.txt");

            StreamWriter fileOut = new StreamWriter("output.txt");
            int n = int.Parse(fileIn.ReadLine());
            PO[] software = new PO[n];
            for (int i = 0; i < n; i++)
            {
                string[] text = fileIn.ReadLine().Split(' ');
                if (text.Length == 2)
                {
                    software[i] = new FREE(text[0], text[1]);
                }
                else
                {
                    if (text.Length == 5)
                    {
                        software[i] = new Shareware(text[0], text[1], text[2], int.Parse(text[3]), int.Parse(text[4]));
                    }

                    else
                    {
                        if (text.Length == 6)
                        {
                            software[i] = new Commercial(text[0], text[1], text[2], int.Parse(text[3]), int.Parse(text[4]), int.Parse(text[5]));
                        }

                    }
                }
            }

                    fileOut.WriteLine("***Все программное обеспечение***");
                    foreach (PO p in software)
                        p.Info(fileOut);
                    

                    fileOut.WriteLine("***Список ПО, которое можно использовать на сегодняшний день***");
                    foreach (PO p in software)
                        if (p.ItIsAWorks()) fileOut.WriteLine(p.ProgramName);
                    

                    fileOut.WriteLine("~~~~ Сортировка по имени:");
                    Array.Sort(software);
                    foreach (PO p in software)
                    {
                        fileOut.WriteLine(p.Name);

                    }
                   
                    fileIn.Close();
                    fileOut.Close();
                }
            }
        }
