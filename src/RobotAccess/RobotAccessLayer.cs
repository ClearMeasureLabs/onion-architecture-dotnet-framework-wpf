namespace RobotAccess
{
    public class RobotAccessLayer
    {
        public string Identifier { get; set; }

        public string IntroduceSelf()
        {
            return $"Hello! I am {Identifier}.";
        }
    }
}
