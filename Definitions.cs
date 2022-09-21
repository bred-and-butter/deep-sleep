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
        public static readonly int interval = 1200;
        public static readonly int level0Start = 0;
        public static readonly int level1Start = 1200;
        public static readonly int level2Start = 2400;
        public static readonly int level3Start = 3600;
        public static readonly int level4Start = 4800;

    }

    public class SleepStateDescriptions
    {
        public static readonly string level0 = "Rested";
        public static readonly string level1 = "Tired";
        public static readonly string level2 = "Drowsy";
        public static readonly string level3 = "Fatigued";
        public static readonly string level4 = "Exhausted";
    }
}
