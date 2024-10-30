using System;
using static animal.Program;

namespace animal
{
    public abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public enum GenderType { Male, Female }
        public GenderType Gender { get; set; }
        public string Breed { get; set; }
        public int HP { get; set; }

        public Animal(int avgLifeTime, GenderType gender, string breed, int hp)
        {
            AvgLifeTime = avgLifeTime;
            Gender = gender;
            Breed = breed;
            HP = hp;
        }
    }

    public class Wolf : Animal
    {
        public bool IsPrideLeader { get; set; }
        public int AttackDamage { get; set; }

        public Wolf(int avgLifeTime, GenderType gender, string breed, int hp, bool isPrideLeader, int attackDamage)
            : base(avgLifeTime, gender, breed, hp)
        {
            IsPrideLeader = isPrideLeader;
            AttackDamage = attackDamage;
        }

        public void Hunt<T>(T prey) where T : Animal
        {
            if (prey.HP > 0)
            {
                prey.HP -= AttackDamage;
                Console.WriteLine($"{Breed} cumur {prey.Breed} neslinde {prey.HP} HP qalib");
            }
            else
            {
                Console.WriteLine($"{prey.Breed} olub");
            }
        }
    }

    public class Elephant : Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }

        public Elephant(int avgLifeTime, GenderType gender, string breed, int hp, double weight, bool isTrained)
            : base(avgLifeTime, gender, breed, hp)
        {
            Weight = weight;
            IsTrained = isTrained;
        }
    }

    public abstract class Food
    {
        public int Calorie { get; set; }

        public Food(int calorie)
        {
            Calorie = calorie;
        }
    }

    public class Meat : Food
    {
        public enum MeatType { Beef, Chicken, Lamb }
        public MeatType Type { get; set; }

        public Meat(int calorie, MeatType type) : base(calorie)
        {
            Type = type;
        }
    }

    public class Grass : Food
    {
        public string Name { get; set; }

        public Grass(int calorie, string name) : base(calorie)
        {
            Name = name;
        }
    }

    public class ZooCage<T, U>
        where T : Animal
        where U : Food
    {
        public T Animal { get; set; }
        public U Food { get; set; }

        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }

        public void DisplayCageInfo()
        {
            Console.WriteLine($"{Animal.Breed} and {Food.GetType().Name} with {Food.Calorie} calories.");
        }
    }
}
