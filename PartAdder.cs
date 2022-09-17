using XRL;
using XRL.World;
using DeepSleep;


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