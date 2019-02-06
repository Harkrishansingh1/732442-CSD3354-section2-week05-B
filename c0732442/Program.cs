using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732442
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        
    }

    class Dog
    {
        public static int NumberofDogs = 0;
        public Dog()
        {
            Dog.NumberofDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
     }
    class LinkedList
    {
        public Dog Head;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();


        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            Jordan.DogName = "Jodan";
            Jordan.DogBreed = "German shepard";
            Fido.DogName = "Fido";
            Fido.DogBreed = "beegle";
        }
    }
}
