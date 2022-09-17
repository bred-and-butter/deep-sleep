using System;
using XRL.World;
using XRL.World.Parts;
using Thresholds;

namespace DeepSleep
{
    [Serializable]
    public class SleepDeprivation : IActivePart
    {
        int fatigue;

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
                IComponent<GameObject>.AddPlayerMessage(CheckThresholds().ToString());
                IComponent<GameObject>.AddPlayerMessage(this.fatigue.ToString());
                IComponent<GameObject>.AddPlayerMessage("True");
            }
            else
            {
                IncreaseFatigue(1);
                IComponent<GameObject>.AddPlayerMessage(CheckThresholds().ToString());
                IComponent<GameObject>.AddPlayerMessage(this.fatigue.ToString());
                IComponent<GameObject>.AddPlayerMessage("False");
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

        private int CheckThresholds()
        {
            if (this.fatigue <= 1200)
            {
                return 1;
            }
            else if (this.fatigue > 1200 || this.fatigue <= 1800)
            {
                return 2;
            }
            else if (this.fatigue > 1800 || this.fatigue <= 2400)
            {
                return 3;
            }
            else if (this.fatigue > 2400 || this.fatigue <= 3000)
            {
                return 4;
            }
            else if (this.fatigue > 3000 || this.fatigue <= 3600)
            {
                return 5;
            }
            else if (this.fatigue > 3600)
            {
                return 6;
            }
            return 0;
        }

    }
}