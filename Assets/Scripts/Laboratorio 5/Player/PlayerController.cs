using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 moveInputs;
    public InputSystem_Actions inputActions;
    public float rotationSpeed = 200f;
    public float moveSpeed = 1.5f;
    private void Awake()
    {
        inputActions = new();
    }
    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Move.performed += ctx => moveInputs = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => moveInputs = Vector2.zero;
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
        transform.Rotate(Vector3.up * moveInputs.x * rotationSpeed * Time.deltaTime);
        Vector3 moveDir = transform.forward * moveSpeed * moveInputs.y;
        PlayerManager.Instance.characterController.Move(moveDir * Time.deltaTime);
    }
}
