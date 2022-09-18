using System;
using XRL.World;
using XRL.World.Parts;
using SerializeField = UnityEngine.SerializeField;

using Thresholds;

namespace DeepSleep
{
    [Serializable]
    public class SleepDeprivation : IActivePart
    {
        [SerializeField]
        public int fatigue;

        public SleepDeprivation()
        {
            WorksOnSelf = true;
            this.fatigue = 0;
        }

        public override bool WantEvent(int ID, int cascade)
        {
            return
                base.WantEvent(ID, cascade)
                || ID == EndTurnEvent.ID
            ;
        }

        public override bool HandleEvent(EndTurnEvent E)
        {
            if (IsReady(UseCharge: true))
            {
                foreach (GameObject obj in GetActivePartSubjects())
                {
                    HandleFatigue(obj);
                }
            }
            return true;
        }

        private void HandleFatigue(GameObject obj)
        {
            if (obj.HasEffect("Asleep"))
            {
                DecreaseFatigue(10);
                IComponent<GameObject>.AddPlayerMessage(Checker.Thresholds(this.fatigue));
                IComponent<GameObject>.AddPlayerMessage(this.fatigue.ToString());
            }
            else
            {
                IncreaseFatigue(1);
                IComponent<GameObject>.AddPlayerMessage(Checker.Thresholds(this.fatigue));
                IComponent<GameObject>.AddPlayerMessage(this.fatigue.ToString());
            }
        }

        private void IncreaseFatigue(int amount)
        {
            this.fatigue += amount;
        }

        private void DecreaseFatigue(int amount)
        {
            if (this.fatigue <= 0)
            {
                this.fatigue = 0;
                return;
            }
            else
            {
                this.fatigue -= amount;
            }
        }
    }
}