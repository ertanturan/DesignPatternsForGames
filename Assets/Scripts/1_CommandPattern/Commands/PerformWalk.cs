using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformWalk : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isWalking");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isWalkingR");
    }
}
