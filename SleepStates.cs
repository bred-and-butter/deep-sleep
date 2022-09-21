using System.Collections.Generic;

using Interfaces;
using DeprivationEffects;
using Ranges = Dataclasses.SleepStateRanges;
using Descriptions = Dataclasses.SleepStateDescriptions;

namespace States
{

    public class Level0 : SleepState
    {
        private readonly List<int> interval = new List<int> { Ranges.level0Start, Ranges.level0Start + Ranges.interval };  // [0, 1200]
        private readonly string description = Descriptions.level0;
        private DeprivationEffect effect;

        public Level0()
        {
            this.effect = new DeprivationEffect(amount: 0, disabled: true);
        }

        public bool IsInInterval(float value)
        {
            return value >= this.interval[0] && value < this.interval[1];
        }

        public string GetDescription()
        {
            return this.description;
        }

        public DeprivationEffect GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level1 : SleepState
    {
        private readonly List<int> interval = new List<int> { Ranges.level1Start, Ranges.level1Start + Ranges.interval };  // [1200, 2400]
        private readonly string description = Descriptions.level1;
        private DeprivationEffect effect;

        public Level1()
        {
            this.effect = new DeprivationEffect(amount: 2);
        }

        public bool IsInInterval(float value)
        {
            return value >= this.interval[0] && value < this.interval[1];
        }

        public string GetDescription()
        {
            return this.description;
        }

        public DeprivationEffect GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level2 : SleepState
    {
        private readonly List<int> interval = new List<int> { Ranges.level2Start, Ranges.level2Start + Ranges.interval };  // [2400, 3600]
        private readonly string description = Descriptions.level2;
        private DeprivationEffect effect;

        public Level2()
        {
            this.effect = new DeprivationEffect(amount: 3);
        }

        public bool IsInInterval(float value)
        {
            return value >= this.interval[0] && value < this.interval[1];
        }

        public string GetDescription()
        {
            return this.description;
        }

        public DeprivationEffect GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level3 : SleepState
    {
        private readonly List<int> interval = new List<int> { Ranges.level3Start, Ranges.level3Start + Ranges.interval };  // [3600, 4800]
        private readonly string description = Descriptions.level3;
        private DeprivationEffect effect;

        public Level3()
        {
            this.effect = new DeprivationEffect(amount: 4);
        }

        public bool IsInInterval(float value)
        {
            return value >= this.interval[0] && value < this.interval[1];
        }

        public string GetDescription()
        {
            return this.description;
        }

        public DeprivationEffect GetAppliedEffect()
        {
            return this.effect;
        }
    }

    public class Level4 : SleepState
    {
        private readonly List<int> interval = new List<int> { Ranges.level4Start, Ranges.level4Start + Ranges.interval };  // [4800, 6000]
        private readonly string description = Descriptions.level4;
        private DeprivationEffect effect;

        public Level4()
        {
            this.effect = new DeprivationEffect(amount: 5);
        }

        public bool IsInInterval(float value)
        {
            return value >= this.interval[0];   // effective interval is 4800 to infinity
        }

        public string GetDescription()
        {
            return this.description;
        }

        public DeprivationEffect GetAppliedEffect()
        {
            return this.effect;
        }
    }

}