using System;

namespace Persons
{
    class Dog : Characters
    {
        public Dog(string type):base(type){}//конструктор наследника
        public void Woof(){
            System.Console.WriteLine("Dog is saying woof");
        }
    }
}
