
namespace BasicOOP2024Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstPart();
            Vehicle v = new Vehicle("Volvo");
            Car c = new Car("Saab", "93");

            Console.WriteLine(v.Drive(50));
            Console.WriteLine(c.Drive(55)); 
        }

        private static void FirstPart()
        {
            //Person p = new Person();
            //string name = p.Name;
            //if(name != null)
            //{
            //    int lenght = name.Length;
            //}

            Person p = new Person();
            p.Name = "Kalle";
            Employee e = new Employee();
            e.Name = "Nisse";
            e.Salary = 25000;
            Admin a = new Admin();
            a.Name = "Lisa";
            a.Salary = 30000;
            a.Department = "IT";


            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();

            //Do(admin);
            //Do(admin2);
            //Do(admin3);
            //Do(p);
            //Do(e);


            List<IPerson> people = new List<IPerson>()
            {
               p,
               e,
               a,
               admin,
               admin2,
               admin3
            };

            //p.Do();
            //e.Do();
            //a.Do();
            //
            foreach (var person in people)
            {
                person.Do();
            }
        }

        private static void Do(Person person)
        {
            Console.WriteLine(person);
        }
    }
}
