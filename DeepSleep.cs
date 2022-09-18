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
        private int fatigue;
        private Disposition disposition;

        public SleepDeprivation()
        {
            WorksOnSelf = true;
            this.fatigue = 0;
            this.disposition = new Disposition();
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
                this.disposition.CheckStateChange(this.fatigue);
                IComponent<GameObject>.AddPlayerMessage(this.disposition.GetState().GetDescription());
                IComponent<GameObject>.AddPlayerMessage(this.fatigue.ToString());
            }
            else
            {
                IncreaseFatigue(1);
                this.disposition.CheckStateChange(this.fatigue);
                IComponent<GameObject>.AddPlayerMessage(this.disposition.GetState().GetDescription());
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