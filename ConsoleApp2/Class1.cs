using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        int Height { get; set; }
        int Weight { get; set; }
        int Age { get; set; }
        string Name { get; set; }

        public Person(string name, int age, int height, int weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

    }
}
