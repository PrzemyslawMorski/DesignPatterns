namespace Builder
{
    public class RobotEngineer
    {
        private readonly RobotBuilder robotBuilder;

        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            robotBuilder.BuildHead();
            robotBuilder.BuildTorso();
            robotBuilder.BuildArms();
            robotBuilder.BuildLegs();
        }
    }
}