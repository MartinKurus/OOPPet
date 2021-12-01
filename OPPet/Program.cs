using System;

namespace OPPet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            public Pet(string _name, int _age)
            {
                name = _name;
                age = _age;
                weight = 0;
                Console.WriteLine($"Pet {name}, {age} year old with {weight} weight has been created");
            }
            public string Name
            {
                get { return name; }
            }
            public int Age
            {
                get { return age; }
            }
            public double Weight
            {
                get { return weight; }
            }
            public void Eating()
            {
                Console.WriteLine("Eating..");
                weight += 0.2;
            }
            public void Exercise()
            {
                Console.WriteLine("Running..");
                weight -= 0.1;
            }
            static void Main(string[] args)
            {
                Pet myPet = new Pet("Hamster", 1);
                Console.WriteLine($"Weight: {myPet.Weight}");

                for (int i = 0; i > 11; i++)
                {
                    while (myPet.weight != 0.7)
                    {
                        myPet.Eating();
                        i++;
                    }
                    myPet.Exercise();
                }
            }
        }
    }
}
