using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;

    private Animator anim;

    private List<Command> _oldCommands = new List<Command>();

    private Command keyQ, keyW, keyE, keySpace, keyR;

    private Coroutine _replayCoroutine;

    private bool _isReplaying;

    private bool _shouldStart;

    private WaitForSeconds _delayForSeconds = new WaitForSeconds(1);

    private void Start()
    {
        keySpace = new PerformJump();
        keyQ = new PerformKick();
        keyR = new PerformPunch();
        keyW = new PerformWalk();
        keyE = new DoNothing();
        anim = actor.GetComponent<Animator>();

    }

    private void Update()
    {
        if (!_isReplaying)
        {
            HandleInput();
        }
        else
        {
            StartReplay();
        }
    }

    private void HandleInput()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
            _oldCommands.Insert(0,keyE);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
            _oldCommands.Insert(0,keyW);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            keyR.Execute(anim);
            _oldCommands.Insert(0,keyR);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
            _oldCommands.Insert(0,keyQ);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
            _oldCommands.Insert(0,keySpace);
        }

        if ( Input.GetKeyDown(KeyCode.Z))
        {
            UndoLastCommand();
        }
    }

    private void StartReplay()
    {
        if (_shouldStart && _oldCommands.Count > 0)
        {

            if (_replayCoroutine != null)
            {
                StopCoroutine(_replayCoroutine);
            }

            _replayCoroutine = StartCoroutine(ReplayCommands());



            _shouldStart = false;
        }
    }

    private void UndoLastCommand()
    {
        if (_oldCommands.Count > 0)
        {
            Command c = _oldCommands[0];
            c.Undo(anim);
            _oldCommands.RemoveAt(0);
        }
    }

    private IEnumerator ReplayCommands()
    {
        _isReplaying = true;
        for (int i = 0; i < _oldCommands.Count; i++)
        {
            _oldCommands[i].Execute(anim);
            yield return _delayForSeconds;
        }

        _isReplaying = false;
    }
}
