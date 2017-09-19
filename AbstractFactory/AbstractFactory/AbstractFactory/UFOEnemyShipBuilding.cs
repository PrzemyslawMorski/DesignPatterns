namespace AbstractFactory
{
    public enum ShipType
    {
        Ufo,
        UfoBoss
    }


    public class UFOEnemyShipBuilding : EnemyShipBuilding<ShipType>
    {
        protected override EnemyShip MakeEnemyShip(ShipType typeOfShip)
        {
            EnemyShip theEnemyShip = null;

            switch (typeOfShip)
            {
                case ShipType.Ufo:
                    EnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
                    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                    theEnemyShip.Name = "Ufo Grunt Ship";
                    break;
                case ShipType.UfoBoss:
                    shipPartsFactory = new UFOBossEnemyShipFactory();
                    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                    theEnemyShip.Name = "Ufo Boss Ship";
                    break;
                default:
                    break;
            }

            return theEnemyShip;
        }
    }
}