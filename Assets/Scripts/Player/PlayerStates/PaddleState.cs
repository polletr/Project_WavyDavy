using UnityEngine;

public class PaddleState : BaseState
{
    public override void EnterState()
    {
        base.EnterState();
        inputManager.EnablePlayerPaddle(); //Start in first phase paddle

    }
    public override void ExitState()
    {

    }

    public override void StateFixedUpdate()
    {
        base.StateFixedUpdate();
    }

    public override void StateUpdate()
    {


    }

    public override void HandlePaddling()
    {
        player.Event.OnGainFlow.Invoke(4f);
    }

    public override void HandleTransition()
    {
        base.HandleTransition();
    }

}