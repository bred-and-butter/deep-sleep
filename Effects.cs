using XRL.World;


namespace DeprivationEffects
{
    public class DeprivationEffect : Effect
    {
        private int amount;
        private bool disabled;

        public DeprivationEffect(int amount = 0, bool disabled = false) : base()
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
