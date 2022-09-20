using XRL.World;


namespace DeprivationEffects
{
    public class SleepDeprived : Effect
    {
        private int amount;

        public SleepDeprived(int amount) : base()
        {
            this.amount = amount;
        }

        public void ApplyStatShifts(GameObject obj)
        {
            this.StatShifter.SetStatShift(target: obj, statName: "Intelligence", amount: amount);
            this.StatShifter.SetStatShift(target: obj, statName: "Willpower", amount: amount);
            this.StatShifter.SetStatShift(target: obj, statName: "Ego", amount: amount);
        }

        public void RemoveStatShifts(GameObject obj)
        {
            this.StatShifter.RemoveStatShifts(target: obj);
        }
    }
}
