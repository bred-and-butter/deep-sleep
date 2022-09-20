using DeprivationEffects;

namespace States
{
    public interface SleepState
    {
        int GetValue();
        float GetValue(float modifier);
        string GetDescription();
        SleepDeprived GetAppliedEffect();
    }

    public class Level0 : SleepState
    {
        private readonly int limit = 1200;
        private readonly string description = "Rested";
        private SleepDeprived effect;

        public Level0()
        {
            this.effect = new SleepDeprived(amount: 1);
        }

        public int GetValue()
        {
            return this.limit;
        }

        public float GetValue(float modifier)
        {
            return this.limit * modifier;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public SleepDeprived GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level1 : SleepState
    {
        private readonly int limit = 1800;
        private readonly string description = "Tired";
        private SleepDeprived effect;

        public Level1()
        {
            this.effect = new SleepDeprived(amount: 2);
        }

        public int GetValue()
        {
            return this.limit;
        }

        public float GetValue(float modifier)
        {
            return this.limit * modifier;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public SleepDeprived GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level2 : SleepState
    {
        private readonly int limit = 2400;
        private readonly string description = "Drowsy";
        private SleepDeprived effect;

        public Level2()
        {
            this.effect = new SleepDeprived(amount: 3);
        }

        public int GetValue()
        {
            return this.limit;
        }

        public float GetValue(float modifier)
        {
            return this.limit * modifier;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public SleepDeprived GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level3 : SleepState
    {
        private readonly int limit = 3000;
        private readonly string description = "Fatigued";
        private SleepDeprived effect;

        public Level3()
        {
            this.effect = new SleepDeprived(amount: 4);
        }

        public int GetValue()
        {
            return this.limit;
        }

        public float GetValue(float modifier)
        {
            return this.limit * modifier;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public SleepDeprived GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level4 : SleepState
    {
        private readonly int limit = 3001;
        private readonly string description = "Exhausted";
        private SleepDeprived effect;

        public Level4()
        {
            this.effect = new SleepDeprived(amount: 5);
        }

        public int GetValue()
        {
            return this.limit;
        }

        public float GetValue(float modifier)
        {
            return this.limit * modifier;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public SleepDeprived GetAppliedEffect()
        {
            return this.effect;
        }
    }

}