namespace Strategy
{
    public interface IFlys
    {
        string Fly();
    }

    public class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : IFlys
    {
        public string Fly()
        {
            return "Cant fly";
        }
    }

        public class FliesSuperFast : IFlys
    {
        public string Fly()
        {
            return "Flying hella fast";
        }
    }
        public class FliesWithWings : IFlys
    {
        public string Fly()
        {
            return "Flies with wings";
        }
    }

}