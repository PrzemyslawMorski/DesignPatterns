using System;

namespace AbstractFactory
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(string typeOfShip);

        public EnemyShip orderTheShip(string typeOfShip)
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