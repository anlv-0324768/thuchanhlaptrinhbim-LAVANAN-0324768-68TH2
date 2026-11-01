using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThucHanh_30_10
{
    public class Person
    {
        public string Name { get; set; }
        public double height;
        public double weight;
        public bool isMale;
        public Person(string Name, double height, double weight, bool isMale)
        {
            this.Name = Name;
            this.height = height;
            this.weight = weight;
            this.isMale = isMale;
        }




    }
}