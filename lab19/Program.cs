using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Модель компьютера  характеризуется  кодом  и  названием  марки компьютера, 
 * типом  процессора, частотой  работы  процессора, 
 * объемом оперативной памяти, объемом жесткого диска, 
 * объемом памяти видеокарты, 
 * стоимостью компьютера в условных единицах и количеством экземпляров,
 * имеющихся в наличии. 
 * Создать список, содержащий 6-10 записей с различным набором значений характеристик.
Определить:
-все компьютеры с указанным процессором. Название процессора запросить у пользователя;
-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
-вывести весь список, отсортированный по увеличению стоимости;
-вывести весь список, сгруппированный по типу процессора;
-найти самый дорогой и самый бюджетный компьютер;
-есть ли хотя бы один компьютер в количестве не менее 30 штук?*/


namespace lab19

{
    class ClassKomp
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Frequency { get; set; }
        public int RAM { get; set; }
        public int Harddisk { get; set; }
        public int Videocard { get; set; }
        public int Cost { get; set; }
        public int Sum { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassKomp> classKomps = new List<ClassKomp>()
            {
                new ClassKomp(){ Code = 1001, Name ="Alex" , Type= "A AMD EPYC 7763", Frequency = 2, RAM = 8, Harddisk = 50, Videocard= 512, Cost = 100, Sum=2 },
                new ClassKomp(){ Code = 1002, Name ="Olga" , Type= "D AMD EPYC 7643", Frequency = 3, RAM = 16, Harddisk = 150, Videocard= 512, Cost = 300, Sum= 65},
                new ClassKomp(){ Code = 1003, Name ="Albert" , Type= "E AMD EPYC 7713", Frequency = 3, RAM = 32, Harddisk = 500, Videocard= 640, Cost = 500, Sum= 4},
                new ClassKomp(){ Code = 1004, Name ="Jon" , Type= "B Intel Xeon Platinum 8380", Frequency = 4, RAM = 32, Harddisk = 900, Videocard= 1000, Cost = 600, Sum= 5},
                new ClassKomp(){ Code = 1005, Name ="Sona" , Type= "Z AMD EPYC 7702", Frequency = 2, RAM = 8, Harddisk = 50, Videocard= 2000, Cost = 50, Sum=6 },
                new ClassKomp(){ Code = 1006, Name ="Juli" , Type= "O AMD EPYC 7763", Frequency = 4, RAM = 32, Harddisk = 500, Videocard= 512, Cost =100 , Sum=7 },
                new ClassKomp(){ Code = 1007, Name ="Andrei" , Type= "W AMD EPYC 7643", Frequency =3 , RAM = 16, Harddisk = 600, Videocard= 3000, Cost = 700, Sum=35},
                new ClassKomp(){ Code = 1008, Name ="Max" , Type= "C AMD Ryzen Threadripper 3960X", Frequency = 2, RAM = 8, Harddisk = 90, Videocard= 40, Cost =950 , Sum=9 },

            };

            //все компьютеры с указанным процессором
            /*Console.WriteLine("Введите наименование процессора");
            string type = Console.ReadLine();
            List<ClassKomp> classKomps1 = classKomps.Where(x => x.Type == type).ToList();
            Print(classKomps1);
            Console.ReadKey();*/


            //все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            /*Console.WriteLine("Введите объем оперативной памяти");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<ClassKomp> classKomps2 = classKomps.Where(r => r.RAM >= ram).ToList();
            Print(classKomps2);
            Console.ReadKey();*/

            //увеличение стоимости Cost
            /*List<ClassKomp> classKomps3 = classKomps.OrderBy(y => y.Cost).ToList();
             Print(classKomps3);
             Console.ReadKey();*/

            //вывести весь список, сгруппированный по типу процессора Type;
            /* IEnumerable<IGrouping<string, ClassKomp>> classKomps4 = classKomps.GroupBy(x => x.Type);
             foreach (IGrouping<string,ClassKomp> gr in classKomps4)
             {
                 Console.WriteLine( gr.Key);
                 foreach(ClassKomp e in gr)
                 {
                     Console.WriteLine($"{e.Code} {e.Name} {e.Type} {e.Frequency} {e.RAM} {e.Harddisk} {e.Videocard} {e.Cost} {e.Sum}");
                 }

             }
             Console.ReadKey();*/


            //найти самый дорогой и самый бюджетный компьютер;
            ClassKomp classKomp5 = classKomps.OrderByDescending(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{classKomp5.Code} {classKomp5.Name} {classKomp5.Type} {classKomp5.Frequency} {classKomp5.RAM} {classKomp5.Harddisk} {classKomp5.Videocard} {classKomp5.Cost} {classKomp5.Sum}");
            ClassKomp classKomp6 = classKomps.OrderBy(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{classKomp6.Code} {classKomp6.Name} {classKomp6.Type} {classKomp6.Frequency} {classKomp6.RAM} {classKomp6.Harddisk} {classKomp6.Videocard} {classKomp6.Cost} {classKomp6.Sum}");



            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            // Console.WriteLine(classKomps.Any(x => x.Sum > 30));

            Console.ReadKey();
        }
        static void Print(List<ClassKomp> classKomps)
        {
            foreach(ClassKomp e in classKomps)
            {
                Console.WriteLine($"{e.Code} {e.Name} {e.Type} {e.Frequency} {e.RAM} {e.Harddisk} {e.Videocard} {e.Cost} {e.Sum}");
            }
            Console.WriteLine();
        }
    }
}
