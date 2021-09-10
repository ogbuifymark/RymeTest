using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Models
{
   public class Rhyme
    {
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string ThirdLine { get; set; }
        public string FourthLine { get; set; }
        public string FifthLine { get; set; }
        public Rhyme()
        {
            this.FirstLine = "Old MacDonald had a farm, E I E I O";
            this.SecondLine = "And on his farm he had a cow, E I E I O";
            this.ThirdLine = "With a moo moo here and a moo moo there";
            this.FourthLine= "Here a moo, there a moo, ev'rywhere a moo moo";
            this.FifthLine = "Old MacDonald had a farm, E I E I O";

        }
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}",
                FirstLine, SecondLine, ThirdLine, FourthLine, FifthLine);
        }
    }
}
