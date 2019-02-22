using UnityEngine;

public class BulletStarter : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float bulletSpeed = 30f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0f, 0f, bulletSpeed);
        Destroy(transform.gameObject, 10f);
    }
}