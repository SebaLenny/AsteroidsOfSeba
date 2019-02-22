using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private float steeringForce = 1f;

    [SerializeField]
    private float thrustForce = 1f;

    private InputController inputController;
    private Rigidbody rb;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddRelativeForce(0f, 0f, thrustForce * inputController.InputVector.y);
        rb.AddTorque(0f, steeringForce * inputController.InputVector.x, 0f);
    }
}