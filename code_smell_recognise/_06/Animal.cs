using System;

namespace code_smell_recognise._06
{
    public abstract class Animal
    {
        protected string Name;

        public void LayEgg() { // 下蛋
            Console.WriteLine("Get an egg.");
        }

        public void Milk() {
            Console.WriteLine("Get milk.");
        }

        public abstract void Provide();
    }
}