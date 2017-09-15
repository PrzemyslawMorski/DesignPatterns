using System;

namespace AbstractFactory
{
    public class UFOEnemyShip : EnemyShip
    {
        private EnemyShipFactory shipFactory;

        public UFOEnemyShip(EnemyShipFactory shipPartsFactory)
        {
            this.shipFactory = shipPartsFactory;
        }

        public override void MakeShip()
        {
            Console.WriteLine($"Making enemy ship {Name}");

            Weapon = shipFactory.AddESGun();
            Engine = shipFactory.AddESEngine();
        }
    }
}