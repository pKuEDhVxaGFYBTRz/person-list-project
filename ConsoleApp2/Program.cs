using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];

            // get initial data
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person(
                    name: Input.InputStr("name", "invalid input"),
                    age: Input.InputInt("age", "invalid input"),
                    height: Input.InputInt("height", "invalid input"),
                    weight: Input.InputInt("weight", "invalid input")
                    );
            }

            // allow details to change
            while (true)
            {
                
            }
        }
    }
}
