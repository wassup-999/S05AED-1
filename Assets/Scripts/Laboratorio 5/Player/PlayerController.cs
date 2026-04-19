using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 movInputs;
    public InputSystem_Actions inputActions;
    public float moveSpeed = 1.5f;
    private void Awake()
    {
        inputActions = new();
    }
    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Move.performed += ctx => movInputs = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => movInputs = Vector2.zero;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        OnMove();
    }
    public void OnMove()
    {
        Vector3 movement = new Vector3(movInputs.x, 0, movInputs.y);
        transform.Translate(movement * moveSpeed * Time.deltaTime) ;
    }
}
