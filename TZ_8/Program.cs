using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ_8
{
    class Program
    {
        public static ObservableCollection<Person> people { get; set; }
        public static Person Person { get; set; }
        static void Main(string[] args)
        {
            people = new ObservableCollection<Person>()
            {
                new Person("Dante","Vergill","Sparda", Convert.ToDateTime("17-10-2001")),
                new Person("Edward","Elric","Hohenheim", Convert.ToDateTime("07-5-1899")),
                new Person("Alphonse","Elric","Hohenheim", Convert.ToDateTime("20-2-1903")),

            };

            Person = new Person();
            Console.Write("Введите имя: ");
            Person.FirstName = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            Person.LasteName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            Person.MiddleName = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            Person.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            people.Add(Person);


            Console.Write("Введите имя человека: ");
            string search = Console.ReadLine();
            var query = people.Where(item => item.FirstName.Contains(search) 
            || item.LasteName.Contains(search) 
            || item.MiddleName.Contains(search));

           foreach (var item in query)
           {
               Console.WriteLine(item.FirstName);
               Console.WriteLine(item.LasteName);
               Console.WriteLine(item.MiddleName);
               Console.WriteLine(item.DateOfBirth);
           }
                Console.ReadKey();
            
        }
    }
}
