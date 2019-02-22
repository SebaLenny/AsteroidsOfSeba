using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour, IDestructible
{
    [SerializeField]
    private int reward = 5;

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}