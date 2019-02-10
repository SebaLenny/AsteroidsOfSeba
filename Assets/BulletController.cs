using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float bulletSpeed = 30f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0f, 0f, bulletSpeed);
        Destroy(transform.gameObject, 10f);
    }
}
