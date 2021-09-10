using RymesTest.Models;
using System;
using System.Collections.Generic;

namespace RymesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi do you know you can make your own poem");
            Console.WriteLine("Below is a sample of what uyou can do");
            Console.WriteLine();
            //var AnimalAndName = new Dictionary<string, string>{ { "Cow", "Moo" }, { "ducks","quack" } ,{ "cat", "meow" },
            //   { "goat","bleat" },{"dog","bark"} };

          //  Solution One
            List<Animals> _Animals = new List<Animals>() {
                new Animals(){Name = "Bear",Sound ="roar"},
                new Animals(){Name = "Bee",Sound ="buzz"},
                new Animals(){Name = "Chicken",Sound ="crow"},
                new Animals(){Name = "Dolphin",Sound ="click"},
                new Animals(){Name = "Donkey",Sound ="hee-haw"}
            };

            // Solution Two
           // Polymorphism refers to changing the behavior of a super class in the subclass
           //which in this case  is the MakeSound() method
            List<Animals> _Animal = new List<Animals>() {
                new cow(),
                new ducks(),
                new cat(),
                new goat(),
                new dog()
            };
            // question Two
            //Take a copy of one of your solutions and extend it to include another 10 animals. 
            List<Animals> _Animal10 = new List<Animals>() {
                new Animals(){Name = "Eagle",Sound ="screech"},
                new Animals(){Name = "Elephant",Sound ="trumpet"},
                new Animals(){Name = "Elk",Sound ="meow"},
                new Animals(){Name = "goat",Sound ="bleat"},
                new Animals(){Name = "Bear",Sound ="roar"},
                new Animals(){Name = "dog",Sound ="bark"},
                new Animals(){Name = "Bee",Sound ="buzz"},
                new Animals(){Name = "Chicken",Sound ="crow"},
                new Animals(){Name = "Dolphin",Sound ="click"},
                new Animals(){Name = "Donkey",Sound ="hee-haw"}
            };
            printPoem(_Animals);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printPoem(_Animal);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printPoem(_Animal10);

            // question Three

            Console.WriteLine("Now type-in the name of the animal u wish to make poem with");
            string UserAnimalName = Console.ReadLine();
            Console.WriteLine("Now type-in the sound the above animal Makes");
            string UserAnimalSound = Console.ReadLine();
            // Note the blow code is going to print same result
            //var UserAnimal = new cow() { Name = UserAnimalName, Sound = UserAnimalSound };
            //List<cow> Animals = new List<cow>();

            var UserAnimal = new Animals(UserAnimalName, UserAnimalSound);
            List<Animals> Animals = new List<Animals>();
            Animals.Add(UserAnimal);
            printPoem(Animals);
            Console.ReadLine();
        }
        public static bool printPoem(IEnumerable<Animals> _Animals)
        {
            try
            {
                int i = 1;
                Rhyme poem = new Rhyme();
                string LastAnimalName = "";
                string LastAnimalSound = "";
                foreach (var animal in _Animals)
                {
                    if (i > 1)
                    {
                        poem.SecondLine = poem.SecondLine.Replace(LastAnimalName, animal.MakeSound());
                        poem.ThirdLine = poem.ThirdLine.Replace(LastAnimalSound, animal.MakeSound());
                        poem.FourthLine = poem.FourthLine.Replace(LastAnimalSound, animal.MakeSound());

                    }
                    else
                    {
                        poem.SecondLine = poem.SecondLine.Replace("cow", animal.MakeSound());
                        poem.ThirdLine = poem.ThirdLine.Replace("moo", animal.MakeSound());
                        poem.FourthLine = poem.FourthLine.Replace("moo", animal.MakeSound());
                    }
                    LastAnimalName = animal.Name;
                    LastAnimalSound = animal.Sound;
                    i++;
                    Console.WriteLine(poem.ToString());
                    Console.WriteLine();
                    Console.WriteLine();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
   }
