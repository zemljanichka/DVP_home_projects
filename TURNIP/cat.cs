using System;

namespace Persons
{
    class Cat : Characters
    {
        public Cat(string type):base(type){}//конструктор наследника
        public void Meow(){
            Console.WriteLine("Cat is saying meow");
        }
    }
}
