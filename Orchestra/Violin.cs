using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra
{
    public class Violin : IMusic
    {
        public string Name { get; set; }
        public Violin(string name)
        {
            Name = name;
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is playing violin");
        }
    }
}
