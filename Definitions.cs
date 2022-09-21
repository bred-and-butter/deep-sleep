using DeprivationEffects;

namespace Interfaces
{
    public interface SleepState
    {
        bool IsInInterval(float value);
        string GetDescription();
        DeprivationEffect GetAppliedEffect();
    }
}

namespace Dataclasses
{
    public class SleepStateRanges
    {
        public const int INTERVAL = 1200;
        public const int LEVEL0START = 0;
        public const int LEVEL1START = 1200;
        public const int LEVEL2START = 2400;
        public const int LEVEL3START = 3600;
        public const int LEVEL4START = 4800;

    }

    public class SleepStateDescriptions
    {
        public const string LEVEL0 = "Rested";
        public const string LEVEL1 = "Tired";
        public const string LEVEL2 = "Drowsy";
        public const string LEVEL3 = "Fatigued";
        public const string LEVEL4 = "Exhausted";
    }
}
