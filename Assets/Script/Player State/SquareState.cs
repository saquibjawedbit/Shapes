using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareState : ShapeBaseState
{
    public override int mass { get { return 100; } }
    public override int speed { get { return 0;  } }

    public override void enterState(ShapeStateManager stateManager)
    {
        stateManager.rb.mass = mass;
        stateManager.SetShape(2);
        stateManager.bCollider.enabled = true;
        stateManager.controller.speed = speed;
    }

    public override void updateState(ShapeStateManager stateManager)
    {
       // throw new System.NotImplementedException();
    }

    public override void attackState(ShapeStateManager stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void onStateExit(ShapeStateManager stateManager)
    {
        stateManager.bCollider.enabled = false;
    }
}
