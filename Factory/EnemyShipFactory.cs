namespace Factory
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string shipType) {
            EnemyShip newShip = null;
            switch(shipType) {
                case "U":
                newShip = new UFOEnemyShip();
                break;
                case "M":
                newShip = new MetalEnemyShip();
                break;
                default:
                break;
            }
            return newShip;
        }
    }
}