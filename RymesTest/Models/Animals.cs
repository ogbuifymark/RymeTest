using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Models
{
    public class Animals
    {
        public string Name { get; set; } = "No-Name";
        public string Sound { get; set; } = "No-Sound";
        public Animals()
        {

        }
        public Animals(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }
        public virtual string  MakeSound()
        {
            return Sound;
        }
    }
}
