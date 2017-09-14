namespace Strategy {
    public class Bird : Animal {
        public void digHole () {
            System.Console.WriteLine ("Dug a hole");
        }

        public Bird () {
            this.Sound = "Squeek";
        }

    }
}