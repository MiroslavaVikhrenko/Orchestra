using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    /*
         Написать код для иерархии классов Оркестр 
        1) Создайте классы Оркестр, Дирижер, Скрипка, Пианино, Гитара. 

        2) У типа Скрипка должен быть метод Играть, который выводит текст "Играет скрипка". 

        3) У типа Пианино должен быть метод Играть, который выводит текст "Играет пианино". 

        4) У типа Гитара должен быть метод Играть, который выводит текст "Играет гитара". 

        5) Оркестр должен иметь в себе инструменты (3 скрипки, 2 гитары и пианино, но подбором инструментов 
        занимается дирижер) и дирижера. 

        6) У типа Дирижер должны быть методы СобратьОркестр, который возвращает Оркестр, и Играть, который 
        вызывает по очереди методы Играть у всех инструментов.*/
    public class Orchestra
    {
        public Conductor Conductor { get; set; }

        public List<IMusic> Instruments { get; set; }

        public Orchestra()
        {
            Conductor = new Conductor("Christine");
            Instruments = Conductor.AssembleTeam();
        }
    }
}
