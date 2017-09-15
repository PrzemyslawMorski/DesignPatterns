namespace Strategy
{
    public interface Flys
    {
        string Fly();
    }

    public class ItFlys : Flys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : Flys
    {
        public string Fly()
        {
            return "Cant fly";
        }
    }

        public class FliesSuperFast : Flys
    {
        public string Fly()
        {
            return "Flying hella fast";
        }
    }
        public class FliesWithWings : Flys
    {
        public string Fly()
        {
            return "Flies with wings";
        }
    }

}