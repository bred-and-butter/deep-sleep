namespace States
{
    public interface SleepState
    {
        int GetValue();
        float GetValue(float modifier);
        string GetDescription();
    }

    public class Level0 : SleepState
    {
        private readonly int limit = 1200;
        private readonly string description = "Rested";

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
    }

    public class Level1 : SleepState
    {
        private readonly int limit = 1800;
        private readonly string description = "Tired";

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
    }

    public class Level2 : SleepState
    {
        private readonly int limit = 2400;
        private readonly string description = "Drowsy";

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
    }

    public class Level3 : SleepState
    {
        private readonly int limit = 3000;
        private readonly string description = "Fatigued";

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
    }

    public class Level4 : SleepState
    {
        private readonly int limit = 3001;
        private readonly string description = "Exhausted";

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
    }

}