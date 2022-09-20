using States;
using System.Collections.Generic;

using XRL.World;

using DeprivationEffects;

namespace Thresholds
{
    public class Disposition
    {
        private SleepState currentState;
        private Dictionary<int, SleepState> possibleStates = new Dictionary<int, SleepState>(){
            {0, new Level0()},
            {1, new Level1()},
            {2, new Level2()},
            {3, new Level3()},
            {4, new Level4()},
        };

        public Disposition()
        {
            this.currentState = this.possibleStates[0];
        }

        public void SetState(SleepState state)
        {
            this.currentState = state;
        }

        public SleepState GetState()
        {
            return this.currentState;
        }

        public void ApplyStatChanges(GameObject obj){
            SleepDeprived effect = this.currentState.GetAppliedEffect();
            effect.ApplyStatShifts(obj);
        }

        public void CheckStateChange(GameObject obj, int fatigue, int modifier = 1)
        {
            if (fatigue > this.possibleStates[3].GetValue(modifier))
            {
                this.SetState(this.possibleStates[4]);
                this.ApplyStatChanges(obj);
                return;
            }
            else if (fatigue > this.possibleStates[2].GetValue(modifier))
            {
                this.SetState(this.possibleStates[3]);
                this.ApplyStatChanges(obj);
                return;
            }
            else if (fatigue > this.possibleStates[1].GetValue(modifier))
            {
                this.SetState(this.possibleStates[2]);
                this.ApplyStatChanges(obj);
                return;
            }
            else if (fatigue > this.possibleStates[0].GetValue(modifier))
            {
                this.SetState(this.possibleStates[1]);
                this.ApplyStatChanges(obj);
                return;
            }

            this.SetState(this.possibleStates[0]);
            this.ApplyStatChanges(obj);
            return;
        }
    }
}

