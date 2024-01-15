using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Classes
{
    public class Animal_Tree
    {
        public static void Entry_Point()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal: ");
            Animal.Action_Animal();
            Console.WriteLine("Mammal: ");
            Mammal.Action_Mammal();
            Console.WriteLine("Cat: ");
            cat.Action_Cat();
            cat.Food();
            cat.Habitat();
            Console.WriteLine("Dog: ");
            dog.Action_Dog();
            dog.Food();
            dog.Habitat();
            Console.WriteLine();
            Console.WriteLine("Single Inheritance: Animal <- Mammal");
            Console.WriteLine("Muti Level Inheritance: Animal <- Mammal <- Dog");
            Console.WriteLine("Hierarchical Inheritance: \n\tAnimal <- Mammal <- Dog \n\tAnimal <- Mammal <- Cat");
            Console.WriteLine("Multiple Inheritance: \n\tMammal, IFood, IHabitat <- Dog \n\tMammal, IFood, IHabitat <- Cat");
        }
    }
    interface IFood
    {
        void Food();
    }
    interface IHabitat
    {
        void Habitat();
    }
    class Animal
    {
        public static void Action_Animal()
        {
            Console.WriteLine("Animal Exists");
        }
    }
    class Mammal : Animal
    {
        public static void Action_Mammal()
        {
            Action_Animal();
            Console.WriteLine("They give birth to baby directly.");
        }
    }
    class Dog : Mammal, IFood, IHabitat
    { 
        public void Action_Dog()
        {
            Action_Mammal();
            Console.WriteLine("They Bark.");
        }
        public void Food()
        {
            Console.WriteLine("They Eat Bone");
        }
        public void Habitat()
        {
            Console.WriteLine("They Sleep in Sofa.");
        }
    }
    class Cat : Mammal, IFood, IHabitat
    {
        public void Action_Cat()
        {
            Action_Mammal();
            Console.WriteLine("They Meow");
        }
        public void Food()
        {
            Console.WriteLine("They Eat Fish");
        }
        public void Habitat()
        {
            Console.WriteLine("They Sleep in warm laptop keyboard.");
        }
    }

}
