using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab6
{
    public class Animal
    {
        public string Name { get; set; }   
        public Animal(string name)
        {
           this.Name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine("This animal is eating");
        }
        public virtual void Walk()
        {
            Console.WriteLine("This animal is walking");
        }
    }

    class Tiger : Animal
    {
        public int Speed { get; set; }
        public Tiger(string name, int speed) :base (name) 
        {
            Speed = speed;
        }
        public override void Eat()
        {
            Console.WriteLine("Tiger is hunting and eating.");
        }

        public override void Walk()
        {
            Console.WriteLine("Tiger is runing.");
        }

        public void Roar()
        {
            Console.WriteLine("Tiger is roaring.");
        }

    }

    class Crocodile : Animal
    {
        public int Length { get; set; }
        public Crocodile(string name, int length) : base(name)
        {
            Length = length;
        }
        public override void Eat()
        {
            Console.WriteLine("Crocodile is hunting and eating.");
        }

        public override void Walk()
        {
            Console.WriteLine("Crocodile is crawling.");
        }

        public void Swim()
        {
            Console.WriteLine("Crocodile is swimming.");
        }

    }


    class Kangaroo : Animal
    {
        public int JumpHeight { get; set; }
        public Kangaroo(string name, int jumpHeight) : base(name)
        {
            JumpHeight = jumpHeight;
        }
        public override void Eat()
        {
            Console.WriteLine("Kangaroo is hunting and eating.");
        }

        public override void Walk()
        {
            Console.WriteLine("Kangaroo is leaping.");
        }

        public void Jump()
        {
            Console.WriteLine("Crocodile is jumping.");
        }

    }

}