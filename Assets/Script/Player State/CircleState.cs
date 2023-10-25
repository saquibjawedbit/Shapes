using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleState : ShapeBaseState
{
    public override int mass { get { return 1; } }
    public override int speed { get { return 10;  } }

    public override void enterState(ShapeStateManager stateManager)
    {
        stateManager.rb.mass = mass;
        stateManager.cCollider.enabled = true;
        stateManager.SetShape(0);
        stateManager.controller.speed = speed;
    }

    public override void updateState(ShapeStateManager stateManager)
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1)) stateManager.switchState(stateManager.squareState);
    }
    public override void attackState(ShapeStateManager stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void onStateExit(ShapeStateManager stateManager)
    {
        stateManager.cCollider.enabled = false;
    }
}
