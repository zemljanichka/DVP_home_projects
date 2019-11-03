using System;
using Persons;
using ConsoleApp;

namespace TURNIP
{
    class Program
    {
        static void Main(string[] args)
        {//создаем всех персонажей
            Cat cat = new Cat("Cat");
            Mouse mouse = new Mouse("Mouse");
            Grandfather grandfather = new Grandfather("Grandfather");
            Grandmother grandmother = new Grandmother("Grandmother");
            Dog dog = new Dog("Dog");
            Granddauther granddauther = new Granddauther("Granddauther");
            dog.Woof();
            cat.Meow(); //рядперсонажей и репку     
            Line characterline = new Line();
            Turnip turnip = new Turnip();
            //пока не вытянем
            do{
                Console.WriteLine("Add a character");
                string newcharacter = Console.ReadLine();//пишем кого хотим добавить
                switch (newcharacter) 
                {//Добавляем персонажа
                    case "Grandfather":
                        characterline.AddCharacter(grandfather);
                        break;
                    case "Grandmother":
                        characterline.AddCharacter(grandmother);
                        break;
                    case "Granddauther":
                        characterline.AddCharacter(granddauther);
                        break;
                    case "Cat":
                        characterline.AddCharacter(cat);
                        break;
                    case "Dog":
                        characterline.AddCharacter(dog);
                        break;
                    case "Mouse":
                        characterline.AddCharacter(mouse);
                        break;
                }
            }while(!turnip.Attempt(characterline));//работаем пока не вытащим
        }
    }
}
