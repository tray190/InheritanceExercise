using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal

    {
        public string Beak { get; set; } = "To fly";
        public string Wings { get; set; } = "brak open nuts";
        public int Talons { get; set; } = 8;
        public bool IsWarmBlooded { get; set; } = true;
        public string Name { get; set; } = "COCO";

        public Bird() { } 
            public Bird(string name, string Beak, string Wings, int Talons, bool IsWarmBlooded)
        {
            Name = name;
            Legs = Legs;
            Age = Age;
            Beak = Beak;
            Wings = Wings;
            Talons = Talons;
            IsWarmBlooded = IsWarmBlooded;
        }
        
    }
    
}
