namespace AbstractFactory
{
    public class UFOEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon AddESGun()
        {
            return new ESUfoGun();
        }

        public ESEngine AddESEngine()
        {
            return new ESUfoEngine();
        }
    }

    public class ESUfoEngine : ESEngine
    {
        public override string ToString()
        {
            return "1000 mph";
        }
    }

    public class ESUfoGun : ESWeapon
    {
        public override string ToString()
        {
            return "20 damage";
        }
    }
}