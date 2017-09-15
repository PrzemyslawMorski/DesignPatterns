using System;

namespace AbstractFactory
{
    public interface EnemyShipFactory
    {
        ESWeapon AddESGun();
        ESEngine AddESEngine();
    }

    public interface ESEngine
    {
    }

    public interface ESWeapon
    {
    }
}