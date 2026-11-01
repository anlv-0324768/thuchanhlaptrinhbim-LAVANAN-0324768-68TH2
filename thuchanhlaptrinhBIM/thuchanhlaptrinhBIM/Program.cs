using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
namespace ThucHanh_30_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // THUC HANH MANG DON
            //  Person person1 = new Person("Sang",175,85,true);
            // Console.WriteLine(person1.Name + "\t" + person1.height + "\t" + person1.weight+ "\t" + person1.isMale);
            //  Console.WriteLine("Ten = " + person1.Name);
            //  Console.WriteLine();

            // THUC HANH CHUOI

            //Person[] people = new Person[10];
            //people[0] = new Person("Sang", 177, 85, true);
            //people[1] = new Person("Nam", 170, 60, true);
            //people[2] = new Person("Bach", 165, 76, true);
            //people[3] = new Person("Duong", 175, 82, true);
            //people[4] = new Person("M.Ngoc", 168, 62, false);

            //Console.WriteLine("Hoten\tHeight\tWeight\tGioitinh");
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(people[i].Name + "\t" + people[i].height + "\t" + people[i].weight + "\t" + people[i].isMale);
            //    Console.WriteLine();

            //}

            //charecter character1= new charecter();
            //character1.Health = 200;
            //Console.WriteLine("Mau cua meo Tom = "+ character1.Health.ToString());


            charecter character = new charecter("Sang", 200);

            Console.WriteLine("chi so mau la: " + character.Health.ToString());


        }
    }
}
