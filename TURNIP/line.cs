using System;
using Persons;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Line//это ряд персонажей
    {
        public List <Characters> line = new List<Characters>();
        public void AddCharacter(Characters character)
        {//можем добавить персонажа в ряд
            int q = 0;
            foreach (Characters i in line)
            {
               //проверяем естьли уже персонаж в ряду
                if(i == character){
                    q = 1;
                }
            }//добавляем, если нет
            if(q == 0){
                line.Add(character);
            }
            if(q == 1){//если есть, говорим что он уже есть
                Console.WriteLine("The character is already in a line");
            }
        }
        public int LineSize(){//для репки
            int t = 0;//проверяем количество персонажей в ряду
            foreach (Characters i in line)
            {
                t++;
                i.Pull();//персонаж из ряда тянет
            }
            return t;   
        }
        
    }
}