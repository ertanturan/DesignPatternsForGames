using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;

    private Animator anim;

    private Command keyQ, keyW, keyE, keySpace, keyR;

    private void Start()
    {
        keySpace = new PerformJump();
        keyQ = new PerformKick();
        keyR = new PerformPunch();
        keyW = new PerformWalk();
        keyE = new DoNothing();
        anim = actor.GetComponent<Animator>();

        Camera.main.GetComponent<CameraFollow360>().player = actor.transform;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            keyR.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
        }


    }
}
