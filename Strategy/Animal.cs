namespace Strategy {

    public class Animal {
        public string Name { get; set; }
        public double Height { get; set; }
        public int Weight {
            get { return Weight; }
            set {
                if (value > 0) {
                    Weight = value;
                } else {
                    System.Console.WriteLine ("Weight must be bigger than 0");
                }
            }
        }
        public string FavFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }

        public virtual void fly () {
            System.Console.WriteLine ("I'm flying!");
        }
    }
}