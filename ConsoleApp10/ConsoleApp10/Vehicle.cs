using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;

    }
        public abstract double Drive()
        {

        }

    public virtual string ShowInfo()
    {
        return ($"Brand: {Brand}\n Color: {Color}\n Millage {Millage} ");        
    }
    }

