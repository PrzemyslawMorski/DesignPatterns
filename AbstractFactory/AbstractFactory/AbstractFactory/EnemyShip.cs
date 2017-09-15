using System;
using System.Text;

namespace AbstractFactory
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public ESWeapon Weapon { get; set; }
        public ESEngine Engine { get; set; }

        public abstract void MakeShip();

        public string ToString()
        {
            string infoOfShip = $"The {Name} has a top speed of {Engine} and an attack power of {Weapon}";
            return infoOfShip;
        }
        
        public void FollowHeroShip()
        {
            System.Console.WriteLine("{0} is following the hero.", Name);
        }

        public void DisplayEnemyShip()
        {
            System.Console.WriteLine("{0} is on the screen.", Name);

        }
        public void EnemyShipShoots()
        {
            System.Console.WriteLine("{0} attacks and does {1} damage.", Name, Weapon);
        }
    }
}