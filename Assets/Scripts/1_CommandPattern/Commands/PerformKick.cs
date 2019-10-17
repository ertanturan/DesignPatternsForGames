using UnityEngine;

public class PerformKick : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isKicking");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isKickingR");
    }
}
