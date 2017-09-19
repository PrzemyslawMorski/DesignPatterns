using System;

namespace AbstractFactory
{
    public abstract class EnemyShipBuilding <ShipType>
    {
        protected abstract EnemyShip MakeEnemyShip(ShipType typeOfShip);

        public EnemyShip orderTheShip(ShipType typeOfShip)
        {
            EnemyShip theEnemyShip = MakeEnemyShip(typeOfShip);

            theEnemyShip.MakeShip();
            theEnemyShip.DisplayEnemyShip();
            theEnemyShip.FollowHeroShip();
            theEnemyShip.EnemyShipShoots();

            return theEnemyShip;
        }
    }
}