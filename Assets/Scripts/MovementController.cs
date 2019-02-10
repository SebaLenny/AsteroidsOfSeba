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
        float thrust = thrustForce * inputController.InputVector.y;
        float steer = steeringForce * inputController.InputVector.x;
        rb.AddRelativeForce(0f, 0f, thrust);
        rb.AddTorque(0f, steer, 0f);
    }
}