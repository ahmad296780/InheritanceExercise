using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public int eyes;
        public string name;
        public string color;
        public int ears;

    }
    public class Bird : Animal
    {
        public int feet;
        public int wings;
        public string voice;
        public double flyingHeight;
    }
    public class Reptile : Animal
    {
        public int backbone;
        public double weight;
        public string skinColor;
        public string eyeColor;
    }   
    
}    
