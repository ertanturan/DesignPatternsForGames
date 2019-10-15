using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;

    private Animator anim;

    private Command keyQ, keyW, keyE;

    private void Start()
    {
        keyQ = new PerformJump();
        keyW = new DoNothing();
        keyE = new DoNothing();
        anim = actor.GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
        }

    }
}
