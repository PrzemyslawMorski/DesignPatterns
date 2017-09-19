using System;

namespace AbstractFactory
{
    public class Program
    {
        private static void Main(string[] args)
        {
            EnemyShipBuilding<ShipType> MakeUfos = new UFOEnemyShipBuilding();

            EnemyShip theGrunt = MakeUfos.orderTheShip(ShipType.Ufo);
            Console.WriteLine(theGrunt.Name);

            EnemyShip theBoss = MakeUfos.orderTheShip(ShipType.UfoBoss);
            Console.WriteLine(theBoss.Name);
        }
    }
}