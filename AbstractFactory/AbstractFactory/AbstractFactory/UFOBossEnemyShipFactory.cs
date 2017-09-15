namespace AbstractFactory
{
    public class UFOBossEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon AddESGun()
        {
            return new ESUfoBossGun();
        }

        public ESEngine AddESEngine()
        {
            return new ESUfoBossEngine();
        }
    }

    public class ESUfoBossEngine : ESEngine
    {
        public override string ToString()
        {
            return "2000 mph";
        }
    }

    public class ESUfoBossGun : ESWeapon
    {
        public override string ToString()
        {
            return "60dmg";
        }
    }
}