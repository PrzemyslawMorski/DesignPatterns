namespace Builder
{
    public interface RobotBuilder
    {
        void BuildHead();

        void BuildTorso();

        void BuildArms();

        void BuildLegs();

        Robot GetRobot();
    }
}