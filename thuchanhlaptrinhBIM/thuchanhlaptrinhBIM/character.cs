using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThucHanh_30_10
{
    public class charecter
    {
        private int _health;

        public string Name { get; set; }
        public int MaxHealth { get; set; } = 100;


        public int Health
        {
            get => _health;
            set
            {

                _health = MaxHealth;
                if (value < 0) _health = 0;
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                    Console.WriteLine("Gia tri cua value: " + value);

                }
                else _health = value;
            }

        }

        public charecter(string name, int health)
        {
            Name = name;
            Health = health;
        }

    }
}