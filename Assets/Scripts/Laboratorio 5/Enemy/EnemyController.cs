using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public InputSystem_Actions inputSystem_Actions;
    [SerializeField] Vector2 moveInputs;
    public float moveSpeed = 1.5f;
    public float rotationSpeed = 200f;
    private void Awake()
    {
        inputSystem_Actions = new();
        
    }
    private void OnEnable()
    {
        inputSystem_Actions.Enable();
        inputSystem_Actions.Enemy.Move.performed += ctx => moveInputs = ctx.ReadValue<Vector2>();
        inputSystem_Actions.Enemy.Move.canceled += ctx => moveInputs = Vector2.zero;
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
        EnemyManager.Instance.enemyCharacterController.Move(moveDir * Time.deltaTime);
    }
}
