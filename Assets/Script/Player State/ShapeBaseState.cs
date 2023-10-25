
/*public enum ShapeState
{
    CIRCLE,
    TRIANGLE,
    SQUARE,
    CYLINDER
}*/


public abstract class ShapeBaseState
{
    abstract public int mass { get; }
    abstract public int speed { get; }
   
    public abstract void enterState(ShapeStateManager stateManager);
    public abstract void updateState(ShapeStateManager stateManager);
    public abstract void attackState(ShapeStateManager stateManager);
    public abstract void onStateExit(ShapeStateManager stateManager);

}
