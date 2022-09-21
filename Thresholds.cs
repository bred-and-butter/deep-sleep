using States;
using System.Collections.Generic;

using XRL.World;

using Interfaces;
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

        public void ApplyStatChanges(GameObject obj)
        {
            DeprivationEffect effect = this.currentState.GetAppliedEffect();
            effect.ApplyStatShifts(obj);
        }

        public void CheckStateChange(int fatigue)
        {
            foreach (SleepState state in this.possibleStates.Values)
            {
                if (state.IsInInterval(fatigue))
                {
                    this.SetState(state);
                }
                
            }
        }
    }
}

