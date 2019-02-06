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
            LinkedList a = new LinkedList();
            a.run();
            a.walkOverTheList();

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
        public Dog current;
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
            Peanut.nextDog = Fifi;
            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            Peanut.nextDog = Jordan;
            Jordan.DogName = "Jodan";
            Jordan.DogBreed = "German shepard";
            Peanut.nextDog = Fido;
            Fido.DogName = "Fido";
            Fido.DogBreed = "beegle";
            Peanut.nextDog = null;
        }
        public void walkOverTheList()
        {
            current = Head;
            while (current != null)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }
        }

    }
}
