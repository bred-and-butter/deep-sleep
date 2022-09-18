namespace Thresholds
{
    public class Checker
    {
        readonly static int rested = 1200; // 1 in-game day
        readonly static int tired = 2400;   // 2 days
        readonly static int drowsy = 3600;  // 3 days
        readonly static int fatigued = 4800;   // 4 days

        public static string Thresholds(int fatigue)
        {
            if (fatigue <= Checker.rested)
            {
                return "Rested";
            }
            else if (fatigue > Checker.rested && fatigue <= Checker.tired)
            {
                return "Tired";
            }
            else if (fatigue > Checker.tired && fatigue <= Checker.drowsy)
            {
                return "Drowsy";
            }
            else if (fatigue > Checker.drowsy && fatigue <= Checker.fatigued)
            {
                return "Fatigued";
            }
            else if (fatigue > Checker.fatigued)
            {
                return "Exhausted";
            }
            return "Error";
        }
    }

    public class Threshold
    {
        private readonly int value;
        private string description;

        public Threshold(int value, string description)
        {
            this.value = value;
            this.description = description;
        }

        public void IsInThreshold(int fatigue, int modifier)
        {

        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

    }

}
