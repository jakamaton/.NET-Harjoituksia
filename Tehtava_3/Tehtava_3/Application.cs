using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tehtava_3
{
    public class Application
    {
        public static List<MenuItem> Menu;

        public static void WriteResult<T>(int itemid, List<T> results){
            string row;
        //otsikkorivit 
        WriteLine();
        WriteLine(Menu.Where(mi => mi.Id==itemid).First().Name.ToUpper());
        WriteLine("‐".PadRight(18*results[0].GetType().GetProperties().Length+2,'‐'));
    //sarakeotsikkorivit
    if (results.Count>0){
    row=""; foreach(PropertyInfo property in results[0].GetType().GetProperties()){
    row+=$"{property.Name}".PadRight(16)+"|";}
    WriteLine(row);
    }
    WriteLine("‐".PadRight(18*results[0].GetType().GetProperties().Length+2,'‐'));
    //data rivit
    foreach (object item in results){
    row="";
    foreach(PropertyInfo property in item.GetType().GetProperties()){
        row+=$"{property.GetValue(item, null).ToString()}".PadRight(16)+"|";
    }
    WriteLine(row);
    }
    WriteLine("‐".PadRight(18*results[0].GetType().GetProperties().Length+2,'‐'));
    WriteLine();
    Write("Paina Enter jatkaaksesi.");
    ReadLine();
}
        public static void InitializeMenu() {
            Menu = new List<MenuItem> {
            new MenuItem() { Id = 1, Name = "50-vuotiaat työntekijät",},
            new MenuItem() { Id = 2, Name = "Osastot yli 50 henkilöä"},
            new MenuItem() { Id = 3, Name = "Sukunimen työntekijät"},
            new MenuItem() { Id = 4, Name = "Osastojen isoimmat palkat"},
            new MenuItem() { Id = 5, Name = "Viisi yleisintä sukunimeä"},
            new MenuItem() { Id = 6, Name = "Osastojen ikäjakaumat"}
        };
            Menu[0].ItemSelected+=(obj,a)=>{
                var tulos = from Department in Data.Employees
                            where Department.Age == 50
                            select new { Nimi = Department.Name, Ika = Department.Age, Osasto = Department.Department.Name };
                WriteLine("| Nimi |"+ " Ika |" + " Osasto |");
                WriteLine("---------------------------------");
                foreach (var olio in tulos) {
                    WriteLine("|"+olio.Nimi+" | "+olio.Ika+" | "+olio.Osasto+"|");
                    WriteLine("---------------------------------");
                }
            };  
            Menu[1].ItemSelected += (obj, a) => {
                var tulos = from Department in Data.Employees
                            where Department.Department.EmployeeCount > 50
                            orderby Department.Department.EmployeeCount
                            select new { Id = Department.Department.Id, Nimi = Department.Department.Name, Vahvuus = Department.Department.EmployeeCount};

                WriteLine("| Id |" + " Nimi |" + " Vahvuus |");
                WriteLine("-----------------------");
                foreach (var olio in tulos.Distinct())
                {
                    WriteLine("|" + olio.Id + " | " + olio.Nimi + " | " + olio.Vahvuus + "|");
                    WriteLine("-------------------");
                }
            };

            Menu[2].ItemSelected += (obj, a) => {
                Console.WriteLine("Anna sukunimi: ");
                string sukunimi = Console.ReadLine();
                var tulos = from Employee in Data.Employees
                            where Employee.LastName.Equals(sukunimi)
                            select new { NIMI = $"{Employee.FirstName} {Employee.LastName}", ID = Employee.Id };

                WriteLine("| Nimi |" + " Id |");
                WriteLine("------------------");
                foreach (var olio in tulos)
                {
                    WriteLine("|" + olio.NIMI + " | " + olio.ID + " | " );
                    WriteLine("-------------------");
                }
            };
            Menu[3].ItemSelected += (obj, a) => {
                var tulos = Data.Departments
                .SelectMany(d => d.Employees, (d, e)
                    => new { Osasto = d.Name, Palkka = e.Salary })
                .GroupBy(tulos => tulos.Osasto, tulos => tulos.Palkka,
                    (BaseOsasto, Palkat) => new { Osasto = BaseOsasto, Palkka = Palkat.Max()});
                WriteLine("| Osasto |" + " Palkka |");
                WriteLine("-----------------------");
                foreach (var olio in tulos)
                {
                    WriteLine("| " + olio.Osasto + " | " + olio.Palkka + " | ");
                    WriteLine("-------------------");
                }

            };

            Menu[4].ItemSelected += (obj, a) => {
                var tulos = Data.Employees.Select((nimi) =>
                            new { Sukunimi = nimi.LastName })
                    .GroupBy(tulos => tulos.Sukunimi,
                    (BaseSukunimi, Sukunimet) => new { Sukunimi = BaseSukunimi, Lkm = Sukunimet.Count() })
                    .OrderByDescending(lkm => lkm.Lkm).Take(5);

                WriteLine("| Sukunimi |" + " Lkm |");
                WriteLine("-----------------------");
                foreach (var olio in tulos)
                {
                    WriteLine("| " + olio.Sukunimi + " | "+olio.Lkm+" |");
                    WriteLine("-------------------");
                }
            };

            Menu[5].ItemSelected += (obj, a) => {
                var tulos = Data.Departments
                .SelectMany(d => d.Employees, (d, e)
                    => new { Osasto = d.Name, Ika = e.Age })
                .GroupBy(x => x.Osasto, (o, i)
                => new { Osasto = o,
                    ika = i.Where(j => j.Ika < 30).Count(),
                    keski = i.Where(j => (j.Ika > 30 && j.Ika < 51)).Count(),
                    vanha = i.Where(j => (j.Ika > 50)).Count()
                }); 
                
                WriteLine("| Osasto |" + " Alle 30v |"+ " 30-50v |"+" Yli 50v |");
                WriteLine("--------------------------------------------------");
                foreach (var olio in tulos)
                {
                    WriteLine("| " + olio.Osasto + " | " + olio.ika + " | "+ olio.keski + " | " + olio.vanha + " | ");
                    WriteLine("------------------------------------------------");
                }

            };
   
        }
        public static void Initialize (){

            Data.GenerateData();
            InitializeMenu();

        }

        public static int ReadFromMenu()
        {

            Console.Clear();
            Console.WriteLine("Vaihtoehdot: ");
            foreach (MenuItem olio in Menu)
            {
                Console.WriteLine(olio);
            }

                try
                {
                    Console.WriteLine("Valitse ( 0 = Lopetus): ");
                    int valinta = int.Parse(ReadLine());
                if (valinta <= 6 && valinta >= 0)
                {
                    return valinta;
                }
                else {
                    throw new ApplicationException();
                }

                }
                catch
                {
                    WriteLine("Virheellinen syöte");
                    ReadLine();
                }
            return 0;
            }

        public static void Run() {
            Initialize();
            do
            {
               int luku = ReadFromMenu();
                if (luku>0) {
                    luku--;
                }
                else if (luku == 0)
                {
                    break;
                }
                Menu[luku].Select();
            } while (true);
        }
    }
}
