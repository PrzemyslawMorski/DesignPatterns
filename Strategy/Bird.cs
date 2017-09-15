namespace Strategy
{
    public class Bird : Animal
    {
        public void digHole()
        {
            System.Console.WriteLine("Dug a hole");
        }

        public Bird()
        {
            Sound = "Squeek";
            FlyingType = new ItFlys();
        }

    }
}