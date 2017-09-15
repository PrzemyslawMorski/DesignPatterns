using System;

namespace AbstractFactory
{
    public class Program
    {
        private static void Main(string[] args)
        {
            EnemyShipBuilding MakeUfos = new UFOEnemyShipBuilding();

            EnemyShip theGrunt = MakeUfos.orderTheShip("Ufo");
            Console.WriteLine(theGrunt.Name);

            EnemyShip theBoss = MakeUfos.orderTheShip("Ufo boss");
            Console.WriteLine(theBoss.Name);
        }
    }
}