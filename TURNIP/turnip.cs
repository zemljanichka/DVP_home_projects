using System;
using Persons;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Turnip{//это репка
        public bool Attempt(Line Lline)//пытаемся ее вытянуть
        {
            if(Lline.LineSize() == 6){//если все персонажи в ряду, вытягиваем
                Console.WriteLine("Success");
                return true;
            }
            else{//нет? ну на нет...продолжаем добавлять
                Console.WriteLine("Fail");
                return false;
            }
        }

    }
}