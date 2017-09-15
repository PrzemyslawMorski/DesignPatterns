using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Which ship do you want to instantiate?");
            EnemyShipFactory shipFactory = new EnemyShipFactory();
            var response = Console.ReadLine();
            var enemyShip = shipFactory.MakeEnemyShip(response.ToString());
            DoStuffEnemy(enemyShip);
        }

        private static void DoStuffEnemy(EnemyShip enemyShip)
        {
            if (enemyShip == null) return;
            enemyShip.DisplayEnemyShip();
            enemyShip.FollowHeroShip();
            enemyShip.EnemyShipShoots();
        }
    }
}
