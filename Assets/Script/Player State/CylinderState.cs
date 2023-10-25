using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderState : ShapeBaseState
{
    public override int mass { get { return 5; } }

    public override int speed => throw new System.NotImplementedException();

    public override void enterState(ShapeStateManager stateManager)
    {
        stateManager.rb.mass = mass;
        stateManager.bCollider.enabled = true;
    }

    public override void updateState(ShapeStateManager stateManager)
    {
        throw new System.NotImplementedException();
    }
    public override void attackState(ShapeStateManager stateManager)
    {
        throw new System.NotImplementedException();
    }

    public override void onStateExit(ShapeStateManager stateManager)
    {
        throw new System.NotImplementedException();
    }
}
