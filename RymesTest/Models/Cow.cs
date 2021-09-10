using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Models
{
   public class cow:Animals
    {
        public cow()
        {
            this.Name = "Cow";
            this.Sound = "Moo";
        }
        public override string MakeSound() { return "Moo"; }
    }
    public class ducks : Animals
    {
        public ducks()
        {
            this.Name = "ducks";
            this.Sound = "quack";
        }
        public override string MakeSound() { return "quack"; }
    }
    public class cat : Animals
    {
        public cat()
        {
            this.Name = "cat";
            this.Sound = "meow";
        }
        public override string MakeSound() { return "meow"; }
    }
    public class goat : Animals
    {
        public goat()
        {
            this.Name = "goat";
            this.Sound = "bleat";
        }
        public override string MakeSound() { return "bleat"; }
    }
    public class dog : Animals
    {
        public dog()
        {
            this.Name = "dog";
            this.Sound = "bark";
        }
        public override string MakeSound() { return "bark"; }
    }
}
