using UnityEngine;

public class PerformPunch : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isPunching");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isPunchingR");
    }
}
