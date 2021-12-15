using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Scales { get; set; } = "would have dry skin and scales";
        public int amnioteEgg { get; set; } = 3;
        public int MetanephricKidney { get; set; } = 2;
        public bool IsColdBlooded { get; set; } = true;

        public Reptile() { } 
            public Reptile(string name, int Scales, string amnioteEgg, int MetanephricKidney, bool IsColdBlooded)
        {
            name = name;
            Legs = Legs;
            Age = Age;
            Scales = Scales;
            amnioteEgg = amnioteEgg;
            MetanephricKidney = MetanephricKidney;
            IsColdBlooded = IsColdBlooded;



        }
    }

    
}
