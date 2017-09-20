namespace Builder
{
    public class OldRobotBuilder : RobotBuilder
    {
        private readonly Robot robot;

        public OldRobotBuilder()
        {
             robot = new Robot();
        }

        public void BuildHead()
        {
            robot.Head = "Tin head";
        }

        public void BuildTorso()
        {
            robot.Torso = "Tin torso";

        }

        public void BuildArms()
        {
            robot.Arms = "Blowtorches";
        }

        public void BuildLegs()
        {
            robot.Legs = "Rollerscates";
        }

        public Robot GetRobot()
        {
            return robot;
        }
    }
}