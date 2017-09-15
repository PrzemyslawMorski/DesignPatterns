namespace AbstractFactory
{
    public class UFOEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = null;

            if (typeOfShip.ToLower().Equals("ufo"))
            {
                EnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
                theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                theEnemyShip.Name = "Ufo Grunt Ship";
            }
            else if (typeOfShip.ToLower().Equals("ufo boss"))
            {
                EnemyShipFactory shipPartsFactory = new UFOBossEnemyShipFactory();
                theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                theEnemyShip.Name = "Ufo Boss Ship";
            }
            return theEnemyShip;
        }
    }
}