namespace Factory
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double DamageOnHit { get; set; }

        public void FollowHeroShip()
        {
            System.Console.WriteLine("{0} is following the hero.", Name);
        }

        public void DisplayEnemyShip()
        {
            System.Console.WriteLine("{0} is on the screen.", Name);

        }
        public void EnemyShipShoots()
        {
            System.Console.WriteLine("{0} attacks and does {1} damage.", Name, DamageOnHit);

        }
    }
}