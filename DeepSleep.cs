using System;
using XRL;
using XRL.World;
using XRL.World.Parts;


[Serializable]
public class SleepDeprivation : IActivePart
{

    public SleepDeprivation()
    {
        WorksOnSelf = true;
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
        bool value;

        if (IsReady(UseCharge: true))
        {
            foreach (GameObject obj in GetActivePartSubjects())
            {
                value = obj.HasEffect("Asleep");
                IComponent<GameObject>.AddPlayerMessage(value.ToString());
            }
        }
        return true;
    }


}

[PlayerMutator]
public class PartAdder : IPlayerMutator
{
    public void mutate(GameObject player)
    {
        // modify the player object when a New Game begins
        // for example, add a custom part to the player:
        player.AddPart<SleepDeprivation>();
    }
}

