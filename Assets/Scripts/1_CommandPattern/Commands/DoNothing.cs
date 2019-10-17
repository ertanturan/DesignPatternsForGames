using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNothing : Command
{
    public override void Execute(Animator anim)
    {

    }

    public override void Undo(Animator anim)
    {
        
    }
}
