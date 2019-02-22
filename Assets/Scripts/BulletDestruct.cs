using UnityEngine;

public class BulletDestruct : MonoBehaviour, IDestructible
{
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}