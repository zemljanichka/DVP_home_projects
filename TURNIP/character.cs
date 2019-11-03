using System;

namespace Persons
{
    class Characters//это персонаж
    {
        public string TypeChar {get; set;}//У него есть тип
        public Characters(string type){ TypeChar = type;}//это конструктор персонажа
        public void Pull(){//он может тянуть
             Console.WriteLine($"{TypeChar} pulls");//говорим, что персонаж тянет
        }
       // public void Gettype(string type){
         //   Type = type;
        //}ну ты расскажешь потом.
    }
}
