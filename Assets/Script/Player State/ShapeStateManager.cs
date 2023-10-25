using UnityEngine;

public class ShapeStateManager : MonoBehaviour
{

    private ShapeBaseState currentState;

    private SpriteRenderer spriteRenderer;
    [HideInInspector]
    public Rigidbody2D rb;
    [HideInInspector]
    public BoxCollider2D bCollider;
    [HideInInspector]
    public CircleCollider2D cCollider;
    [HideInInspector]
    public PlayerController controller;
    public Sprite[] shapes;
   

    public CircleState circleState = new CircleState();
    public TriangleState triangleState = new TriangleState();
    public SquareState squareState = new SquareState();
    public CylinderState cylinderState = new CylinderState();
    public RectangleState rectangleState = new RectangleState();
    public LineState lineState = new LineState();
    public KiteState kiteState = new KiteState();
    public HexagonState hexagonState = new HexagonState();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bCollider = GetComponent<BoxCollider2D>();
        cCollider = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        currentState = circleState;
        currentState.enterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.updateState(this);
        if (Input.GetKeyDown(KeyCode.Alpha1)) switchState(circleState);
        else if (Input.GetKeyDown(KeyCode.Alpha2)) switchState(squareState);
        else if (Input.GetKeyDown(KeyCode.Alpha3)) switchState(cylinderState);
        else if (Input.GetKeyDown(KeyCode.Alpha4)) switchState(triangleState);
    }

    public void switchState(ShapeBaseState state)
    {
        currentState.onStateExit(this);
        currentState = state;
        currentState.enterState(this);
    }

    public void SetShape(int index)
    {
        spriteRenderer.sprite = shapes[index];
    }
}
