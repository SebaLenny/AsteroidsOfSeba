using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        IDestructible otherDestructibleBehaviour = collision.gameObject.GetComponent<IDestructible>();
        IDestructible thisDestructibleBehaviour = GetComponent<IDestructible>();
        if (otherDestructibleBehaviour != null)
        {
            otherDestructibleBehaviour.DestroySelf();
        }
        if (thisDestructibleBehaviour != null)
        {
            thisDestructibleBehaviour.DestroySelf();
        }
    }
}