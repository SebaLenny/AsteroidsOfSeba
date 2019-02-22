using UnityEngine;

public class BorderBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    private float halfHeight;
    private float halfWidth;

    private void OnEnable()
    {
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 predictedPosition = rb == null ? transform.position : transform.position + rb.velocity * Time.deltaTime;
        if (predictedPosition.z > halfHeight || predictedPosition.z < -halfHeight)
        {
            transform.position = transform.position.With(z: -transform.position.z);
        }
        if (predictedPosition.x > halfWidth || predictedPosition.x < -halfWidth)
        {
            transform.position = transform.position.With(x: -transform.position.x);
        }
    }
}