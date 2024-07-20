using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name) 
        {
            Name = name;
        } 
        public abstract void Say();
        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        private string name;
        public Cat(string name)
            :base(name) 
        {}

        public override string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        private string name;
        public Dog(string name)
            : base(name)
        { }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
