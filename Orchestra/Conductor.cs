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
    public class Conductor
    {
        public string Name { get; set; }
        public Conductor(string name)
        {
            Name = name;
        }
        public void Play(Orchestra orchestra)
        {
            Console.WriteLine($"~ ~ Conductor {Name} is orchestrating ~ ~ ");
            foreach (var instrument in orchestra.Instruments)
            {
                instrument.Play();
            }
        }

        public List<IMusic> AssembleTeam()
        {
            List<IMusic> team = new List<IMusic>
            {
                new Violin("Rachel"), 
                new Violin("Sophia"), 
                new Violin("Chris"), 
                new Guitar("Peter"), 
                new Guitar("David"), 
                new Piano("Rose") 
            };
            Console.WriteLine($"Conductor {Name} assembled a team.");
            return team;
        }
    }
}
