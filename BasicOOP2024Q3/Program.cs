
namespace BasicOOP2024Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Kalle";
            var res = name.AddString("Anka");
            Console.WriteLine(res);

            string test = "Test";
            var res2 = test.AddString("test");
            Console.WriteLine(res2);


            //Person p = new Person();
            //Employee e = new Employee();
            //Admin a = new Admin();

            //p.Do();
            //e.Doing();
            //a.Do(); 



            //FirstPart();            
            Vehicle v = new Vehicle("Volvo");
            //ProtectedBool syns inte
            //v.ProtectedBool = 
            Console.WriteLine(v.Turn()); 
            Car c = new Car("Saab", "93");
            Console.WriteLine(c.Turn());
            Saab s = new Saab();
            //Console.WriteLine(v.Drive(50));
            //Console.WriteLine(c.Drive(55));
            //Console.WriteLine(s.Brand);
            //Console.WriteLine(s.Model);

            List<IDrivable> vehicles = new List<IDrivable>
            {
                v,
                c,
                s
            };

            foreach (IDrivable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //unsafe cast
                //Saab saab = (Saab)vehicle;

                //Saab saab = vehicle as Saab;
                //Console.WriteLine(saab.SaabSpecialMethod());

                //Saab saab = vehicle as Saab;
                //if(saab != null)
                //{
                //    Console.WriteLine(saab.SaabSpecialMethod());
                //}

                //if(vehicle is Saab)
                //{
                //    Saab saab = (Saab)vehicle;
                //    Console.WriteLine(saab.SaabSpecialMethod());
                //}

                if(vehicle is Saab castedToSaab)
                {
                    Console.WriteLine(castedToSaab.SaabSpecialMethod());
                }

            }


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
