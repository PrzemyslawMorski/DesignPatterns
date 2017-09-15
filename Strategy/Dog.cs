namespace Strategy
{
    public class Dog : Animal
    {
        public void digHole()
        {
            System.Console.WriteLine("Dug a hole");
        }

        public Dog()
        {
            Sound = "Bark";
            FlyingType = new CantFly();
        }
    }
}