using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformJump : Command
{

    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isJumping");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isJumpingR");
    }
}
