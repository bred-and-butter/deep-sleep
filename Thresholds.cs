using States;
using System.Collections.Generic;

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

        public bool CheckStateChange(int fatigue, int modifier = 1)
        {
            if (fatigue <= this.possibleStates[0].GetValue(modifier))
            {
                this.SetState(this.possibleStates[0]);
                return true;
            }
            else if (fatigue > this.possibleStates[0].GetValue(modifier) && fatigue <= this.possibleStates[1].GetValue(modifier))
            {
                this.SetState(this.possibleStates[1]);
                return true;
            }
            else if (fatigue > this.possibleStates[1].GetValue(modifier) && fatigue <= this.possibleStates[2].GetValue(modifier))
            {
                this.SetState(this.possibleStates[2]);
                return true;
            }
            else if (fatigue > this.possibleStates[2].GetValue(modifier) && fatigue <= this.possibleStates[3].GetValue(modifier))
            {
                this.SetState(this.possibleStates[3]);
                return true;
            }
            else if (fatigue > this.possibleStates[3].GetValue(modifier))
            {
                this.SetState(this.possibleStates[4]);
                return true;
            }
            return false;
        }
    }
}

